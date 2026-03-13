using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    [Header("Points")]
    [Range(0,100)]public int _CurrentPoints = 0;
    public int _rewardingPoints = 10;
    public int _maxPoints = 100;

    public bool _allDead = false;
    public float AmountDead = 0f;

    [SerializeField]
    private RectTransform _barRect;

    // Desired Top values
    private float topAtZero = -39.6f;
    private float topAtMax = 53.6f;

    private float _maxHightMask;
    private float _initialHightMask;

    public void setValue(int newValue)
    {
        var targetHight = newValue * _maxHightMask / _maxPoints;
        var newRightMask = _maxHightMask + _initialHightMask - targetHight;
    }

    void Update()
    {
        Health[] allHealthScripts = FindObjectsOfType<Health>();

        foreach (Health h in allHealthScripts)
        {
            if (h._health <= 0 && !h._isDead)
            {
                _CurrentPoints += _rewardingPoints;
                h._isDead = true;

                Debug.Log("Quest Completed for: " + h.name);

                AmountDead += 1;
            }
        }

        UpdateBarPosition();

        if (AmountDead >= 2)
        {
            _allDead = true;
        }
    }

    private void UpdateBarPosition()
    {
        // Convert points to 0–1 range
        float t = Mathf.Clamp01((float)_CurrentPoints / _maxPoints);

        // Interpolate between top values
        float newTop = Mathf.Lerp(topAtZero, topAtMax, t);

        // Apply to RectTransform
        Vector2 offsetMax = _barRect.offsetMax;
        offsetMax.y = newTop;
        _barRect.offsetMax = offsetMax;
    }
}

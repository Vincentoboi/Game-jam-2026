using UnityEngine;

public class PointSystem : MonoBehaviour
{
    [Header("script varibles")]
    public int _CurrentPoints = 0;
    public int _rewardingPoints;

    [Header("Script Bool")]
    public bool _questCompleted = false;

    [Header("Take from scripts")]
    public Health _healthScript;

    [Header("Health: float")]
    public float _health;
    

    // Update is called once per frame
    void Update()
    {
        _health = _healthScript._health;

        if (_health == 0)
        {
            _questCompleted = true;
        }

        if (_questCompleted)
        {
            _CurrentPoints += _rewardingPoints;
            _questCompleted = false;
            print("Quest Completed");
        }
    }
}
    
//This gives points for the game objective when a sertain task is completed.
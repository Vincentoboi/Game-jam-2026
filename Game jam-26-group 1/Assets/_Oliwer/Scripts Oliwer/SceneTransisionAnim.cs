using UnityEngine;
using System.Collections;

public class SceneTransisionAnim : MonoBehaviour
{
    public Animator _playerAnim;
    public PointManager _pointManagerScript; // kept exactly as you asked
    public FinishPoint _finishPointScript;

    void Start()
    {
        // Keep animator off so it doesn't override movement
        _playerAnim.enabled = false;
    }

    void Update()
    {
        if (_finishPointScript._transitionScene)
        {
            PlayTransitionAnimation();
        }
    }

    void PlayTransitionAnimation()
    {
        // Enable animator only when needed
        _playerAnim.enabled = true;

        // Play your animation from the start
        _playerAnim.Play("SceneTranstion", 0, 0f);

        // Find the animation length
        float animLength = 0f;
        foreach (var clip in _playerAnim.runtimeAnimatorController.animationClips)
        {
            if (clip.name == "SceneTranstion")
            {
                animLength = clip.length;
                break;
            }
        }

        // Disable animator after animation finishes
        StartCoroutine(DisableAnimatorAfter(animLength));
    }

    IEnumerator DisableAnimatorAfter(float time)
    {
        yield return new WaitForSeconds(time);

        // Turn animator off again so movement works
        _playerAnim.enabled = false;
    }
}

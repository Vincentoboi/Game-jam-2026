using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [Header("If true, play animation on next scene of buildIndex")]
    [SerializeField] public bool _TransitionSelected;

    [Header("Script Bool:")]
    public bool _transitionScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Go to next level
            SceneController._instance.NextLevel();
        }
        if (other.CompareTag("Player") && _TransitionSelected) 
        {
            SceneController._instance.NextLevel();
            _transitionScene = true;
        }
        else
        {
            _transitionScene = false;
        }
        //if there is collsion and the bool is selected,go to the next scene of buildIndex and play the animation.
        //if there is not both of them, and only collision. only go to next scene of buildIndex without animation.
        // if there is no collision and the bool is not true, return the "_transitionScene" to false.
    }
}

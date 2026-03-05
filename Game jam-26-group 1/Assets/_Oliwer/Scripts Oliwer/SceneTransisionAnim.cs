using UnityEngine;

public class SceneTransisionAnim : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneController._instance.TransitionLevel();
        }
    }
}

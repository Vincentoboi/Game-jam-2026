using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public PointManager _pointManagerScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            print("ResetGame");
            // Destroy all DontDestroyOnLoad objects
            DontDestroy.ResetPersistentObjects();

            // Reset points
            _pointManagerScript._CurrentPoints = 0;

            // Load your next scene
            SceneController._instance.StartScreen();
        }
    }
}

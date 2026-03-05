using System.Net;
using UnityEngine;

public class SceneTransisionAnim : MonoBehaviour
{
    public PointManager _pointManagerScript;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneController._instance.TransitionLevel();
        }
    }
}

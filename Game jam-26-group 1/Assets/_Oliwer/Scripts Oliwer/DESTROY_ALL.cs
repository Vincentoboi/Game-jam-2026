using UnityEngine;

public class DESTROY_ALL : MonoBehaviour
{
    void Start()
    {
        var player = FindObjectOfType<PlayerMove>();
        if (player != null)
            Destroy(player.gameObject);

        var pointManager = FindObjectOfType<PointManager>();
        if (pointManager != null)
            Destroy(pointManager.gameObject);

        var SceneController = FindObjectOfType<SceneController>();
        if (SceneController != null)
            Destroy(SceneController.gameObject);

        var bla = FindObjectOfType<BlaScript>();
        if (bla != null)
            Destroy(bla.gameObject);
    }
}

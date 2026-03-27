using UnityEngine;
using UnityEngine.SceneManagement;

public class Skräp : MonoBehaviour
{
    public void EndScene()
    {
        SceneManager.LoadScene(0);
    }
}

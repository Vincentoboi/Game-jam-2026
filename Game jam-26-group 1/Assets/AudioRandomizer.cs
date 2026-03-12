using UnityEngine;

public class AudioRandomizer : MonoBehaviour
{
    public RunAway script;

    public AudioSource audioSource;
    public AudioClip[] mySounds;

    private AudioClip activeSound;



    // Update is called once per frame
    void Update()
    {
        // press spacebar for random sound
        if (Input.GetKeyDown(KeyCode.O))
        {
            activeSound = mySounds[Random.Range(0, mySounds.Length)];

            audioSource.PlayOneShot(activeSound);
        }
        float audioLength;
        foreach (var Audio in mySounds)
        {
            audioLength = Audio.length;
            break;
        }
    }
}

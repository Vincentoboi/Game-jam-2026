using UnityEngine;

public class AudioRandomizer : MonoBehaviour
{
    public RunAway script;

    public AudioSource audioSource;
    public AudioClip[] mySounds;

    private AudioClip activeSound;
    bool okayToPlayAudio;
    bool hasAudioPlayed;
    public float timeLeft = 1f;



    
    public void Sound()
    {
        //float audioLength;
        
        if (timeLeft > 0.0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            okayToPlayAudio = true;
        }
        if (okayToPlayAudio && !hasAudioPlayed)
        {
            activeSound = mySounds[Random.Range(0, mySounds.Length)];
            audioSource.PlayOneShot(activeSound);
            hasAudioPlayed = true;
        }

        

        
        //foreach (var Audio in mySounds)
        //{
        //    audioLength = Audio.length;
        //    break;
        //}
    }
}
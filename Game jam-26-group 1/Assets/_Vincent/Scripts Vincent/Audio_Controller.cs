using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    public AudioSource aud;
    public AudioClip Walk, Run, Slash;

    public void Walking()
    {
        aud.clip = Walk;
        aud.Play();
    }
    public void Running()
    {
        aud.clip = Run;
        aud.Play();
    }
    public void Slashing()
    {
        aud.clip = Slash;
        aud.Play();
    }
}

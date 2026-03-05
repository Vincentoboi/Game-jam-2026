using UnityEngine;

public class Audio_Controller : MonoBehaviour
{

    AudioSource aud;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play_Sound()
    {
        aud.Play();
    }
}

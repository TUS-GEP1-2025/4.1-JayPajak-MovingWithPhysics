using UnityEngine;

public class radioController : MonoBehaviour

{
    public AudioSource theAudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayNextSong();
    }

    public void PlayNextSong()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            theAudioSource.Play();
        }
    }
}

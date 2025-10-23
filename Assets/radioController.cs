using UnityEngine;
using System.Collections.Generic;

public class radioController : MonoBehaviour

{
    public AudioSource theAudioSource;
    public List<AudioClip> playList = new List<AudioClip>();
    public int songIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PlayNextSong()
    {
            theAudioSource.clip = playList[songIndex];
            theAudioSource.Play();
            songIndex++;

        if(songIndex == 4)
        {
            songIndex = 0;
        }
    }


    public void StopPlayingSong()
    {
        theAudioSource.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_manager : MonoBehaviour
{

    public AudioClip[] Songs;

    public int currentSong;

    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        currentSong = 0;
        _audioSource.clip = Songs[currentSong];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        _audioSource.GetComponent<AudioSource>();
    }

    public void PlaySong()
    {
        _audioSource.clip = Songs[currentSong];
        _audioSource.Play();


    }
    
    public void NextSong()
    {
        currentSong++;
        if (currentSong >= Songs.Length)
        {
            currentSong = 0;
        }
        PlaySong();
    }

    public void PreviousSong() {
        currentSong--;
        if (currentSong < 0)
        {
            currentSong = Songs.Length - 1;
        }
        PlaySong();
    }

}

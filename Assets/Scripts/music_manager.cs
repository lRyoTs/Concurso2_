using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class music_manager : MonoBehaviour
{

    public AudioClip[] Songs;
    public string [] artists;
    private int currentSong;

    private AudioSource _audioSource;

    public TextMeshProUGUI songText;
    public TextMeshProUGUI artistText;

    // Start is called before the first frame update
    void Start()
    {

        currentSong = 0;
        _audioSource.clip = Songs[currentSong];
        UpdateSongName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    //Function that plays the song
    public void PlaySong()
    {
        _audioSource.clip = Songs[currentSong];
        _audioSource.Play();
    }
    
    //Function that plays the next song
    public void NextSong()
    {
        currentSong++;
        if (currentSong >= Songs.Length)
        {
            currentSong = 0;
        }
        PlaySong();
        UpdateSongName();
    }

    //Function that plays the previous song
    public void PreviousSong() {
        currentSong--;
        if (currentSong < 0)
        {
            currentSong = Songs.Length - 1;
        }
        PlaySong();
        UpdateSongName();
    }

    //Function that choices a random song
    public void RandomSong()
    {
        currentSong = Random.Range(0,Songs.Length);
        PlaySong();
        UpdateSongName();
    }


    public void RestartSong() {
        _audioSource.Stop();
        PlaySong();
    }
    //Function that updates song info
    public void UpdateSongName() {
        artistText.text = artists[currentSong]; //update artist name
        songText.text = Songs[currentSong].name; //Update song name
    }

}

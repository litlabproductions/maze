using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public float timeToLoopMusic;
    public float currentPlayCountdown;

    public AudioSource[] audioSources;

    public  int randSongID;

    void Start ()
    {
       // currentPlayCountdown = timeToLoopMusic;
        //ChangeSong();
    }

    void Update()
    {
        //currentPlayCountdown -= Time.deltaTime;

        // if (currentPlayCountdown <= 0)
        // {
        //    StartCoroutine(AudioFadeScript.FadeOut(audioSources[randSongID], 0.5f));
        //    ChangeSong();
        //     currentPlayCountdown = timeToLoopMusic;
        //  }

        if (!audioSources[randSongID].isPlaying)
            audioSources[randSongID].Play();

        audioSources[randSongID].volume = PlayerPrefs.GetFloat("SoundVolume");

    }

    public void ChangeSong()
    {
        //randSongID = Random.Range(0, audioSources.Length);
        //StartCoroutine(AudioFadeScript.FadeIn(audioSources[randSongID], 1.5f));
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SplashSetup : MonoBehaviour 
{
    void Start () 
	{
        PlayerPrefs.SetInt("AdvDeathCount", 0);
        PlayerPrefs.SetFloat("SoundVolume", 1.0f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
    }
}

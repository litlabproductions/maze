using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text highscoreText;

    public Image soundButtonImage;
    public Image soundButtonIconImage;

    void Start ()
    {
        highscoreText.text = PlayerPrefs.GetInt("HighScore").ToString();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
           Application.Quit();

        if (PlayerPrefs.GetFloat("SoundVolume") > 0)
        {
            soundButtonImage.color = new Color(1f, 1f, 1f, 1f);
            soundButtonIconImage.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            soundButtonImage.color = new Color(1f, 1f, 1f, 0.3f);
            soundButtonIconImage.color = new Color(1f, 1f, 1f, 0.3f);
        }         
    }

    public void ToGame ()
    {
        StartCoroutine(LoadGame());
    }

    public void ToPlayStore()
    {
        StartCoroutine(LoadPlayStore());
    }

    public void ToAbout()
    {
        StartCoroutine(LoadAbout());
    }

    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameScene");
    }

    IEnumerator LoadPlayStore()
    {
        yield return new WaitForSeconds(1.0f);
        Application.OpenURL("market://details?id=" + Application.productName);
    }

    IEnumerator LoadAbout()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("AboutScene");
    }

    public void ToggleMuteMusic()
    {
        if (PlayerPrefs.GetFloat("SoundVolume") > 0)
        {
            PlayerPrefs.SetFloat("SoundVolume", 0.0f);
        }
        else
        {
            PlayerPrefs.SetFloat("SoundVolume", 1.0f);
        }
    }
}

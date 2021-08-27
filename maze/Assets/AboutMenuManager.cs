using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutMenuManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("MenuScene");
    }

    public void ToInstagram()
    {
        StartCoroutine(LoadInstagram()); 
    }

    IEnumerator LoadInstagram()
    {
        yield return new WaitForSeconds(1.0f);
        Application.OpenURL("https://www.instagram.com/litlabproductions/?hl=en");
    }

    public void ToYouTube()
    {
        StartCoroutine(LoadYouTube());
    }

    IEnumerator LoadYouTube()
    {
        yield return new WaitForSeconds(1.0f);
        Application.OpenURL("https://www.youtube.com/channel/UCG6Y3kCD43Dwlt60hTRJZQA");
    }

    public void ToWebsite()
    {
        StartCoroutine(LoadWebsite());
    }

    IEnumerator LoadWebsite()
    {
        yield return new WaitForSeconds(1.0f);
        Application.OpenURL("https://www.litlabproductions.com/");
    }

    public void ToMenu()
    {
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("MenuScene");
    }
}

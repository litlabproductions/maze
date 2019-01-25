using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenuManager : MonoBehaviour
{
    public void ToGame ()
    {
        StartCoroutine(StartGame());
    }

    public void ToMenu()
    {
        StartCoroutine(StartMenu());
    }


    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameScene");

    }

    IEnumerator StartMenu()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("MenuScene");

    }
}

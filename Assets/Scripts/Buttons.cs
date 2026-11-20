using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject settingsCanvas;
    [SerializeField] AudioSource cameraSoundSource;
    [SerializeField] AudioClip buttonClickSound;
 
    public void StartGame()
    {
        cameraSoundSource.PlayOneShot(buttonClickSound);
        SceneManager.LoadScene("Gameplay");
    }

    public void OpenSettings()
    {
        cameraSoundSource.PlayOneShot(buttonClickSound);
        menuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }

    public void CloseSettings()
    {
        cameraSoundSource.PlayOneShot(buttonClickSound);
        menuCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }

    public void BackToMenu()
    {
        cameraSoundSource.PlayOneShot(buttonClickSound);
        SceneManager.LoadScene("MainMenu");
    }

    public void Abort()
    {
        cameraSoundSource.PlayOneShot(buttonClickSound);
        Application.Quit();
        Debug.Log("QuitGame");
  
    }

}

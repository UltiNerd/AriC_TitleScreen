using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject settingsCanvas;

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void OpenSettings()
    {
        menuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }

    public void CloseSettings()
    {
        menuCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Abort()
    {
        Application.Quit();
    }
}

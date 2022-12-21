using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScr : MonoBehaviour
{
    public void scenePlay(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenPanel(GameObject Panel )
    {
        Panel.SetActive(true);
    }
    public void ClosePanel(GameObject Panel)
    {
        Panel.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

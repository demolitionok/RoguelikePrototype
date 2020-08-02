using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingPanel;
    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }
    public void EnableSettingsPanel()
    {
        settingPanel.SetActive(true);
    }
    public void DisableSettingsPanel()
    {
        settingPanel.SetActive(false);
    }
    public void ExitGame() 
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}

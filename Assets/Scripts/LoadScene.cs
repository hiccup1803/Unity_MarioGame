using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("1-1");
        Data.level = 1;
    }

    public void LoadLevel2()
    {
        if(Data.level == 1)
            {SceneManager.LoadScene("1-2");
            Data.level = 2;
            }
        else
            SceneManager.LoadScene("StartScene");

    }

    public void LoadSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }

    public void LoadHelp()
    {
        SceneManager.LoadScene("HelpScene");
    }

    public void RunExitApp(){
        Application.Quit();
    }

    
}

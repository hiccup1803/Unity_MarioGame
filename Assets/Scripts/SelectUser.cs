using System.Data.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectUser : MonoBehaviour
{

    public int flag;

    public void onSelect1(){
        flag = 0;
    }

    public void onSelect2(){
        flag = 1;
    }

    public void onSelect3(){
        flag = 2;
        
    }

    public void onSelect4(){
        flag = 3;
    }

    public void onSelect5(){
        flag = 4;
    }

    public void onSelect6(){
        flag = 5;
    }

    public void onClick(){
        Data.flag = flag;
        Debug.Log(flag);
        SceneManager.LoadScene("StartScene");
    }
}


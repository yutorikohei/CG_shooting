using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_to_game : MonoBehaviour {

    private void On_Start_Button () 
    {
        //SceneManager.LoadScene("GameMain");
        FadeManager.Instance.LoadScene ("GameMain", 1.0f);
    }

    public void Off_End_Button()
    {
        Application.Quit();
        Debug.Log("test");
    }
}
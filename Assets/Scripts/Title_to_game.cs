using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_to_game : MonoBehaviour
{
    //ボタンでゲームに遷移
    public void On_Start_Button()
    {
        Debug.Log("mainに遷移");
        SceneManager.LoadScene("Main");

    }
}

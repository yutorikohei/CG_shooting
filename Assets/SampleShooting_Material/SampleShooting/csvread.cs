using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;　　　　// 追記
using UnityEngine.SceneManagement;

public class csvread : MonoBehaviour
{
    public TextAsset csvFile;   　　　　　// GUIでcsvファイルを割当
　　List<string[]> csvDatas = new List<string[]>(); //ここは参考ブログとは違う
    public Text textUI;
    public Text AnswerUI;
    public string quiz;
    public string answer;
    public int exm;
    public string word;
    public string playeranswer = "";

    public GameObject Rock;

　　　　// Use this for initialization
　　　　void Start()
    {

　　　　　　　　// 格納
　　　　　　　　string[] lines = csvFile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (var line in lines)
        {
            if (line == "") { continue; }
            csvDatas.Add(line.Split(','));　　　　// string[]を追加している
　　　　　　　　}

        // 書き出し
        var number = Random.Range(1, 3);
        textUI.text = csvDatas[number][0];

        quiz = csvDatas[number][0];
        answer = csvDatas[number][1];
        exm = int.Parse(csvDatas[number][2]);
        word = csvDatas[number][3];
        Debug.Log(quiz);
        Debug.Log(exm);
        Debug.Log(answer);
        FadeController.isFadeIn = true;
        Invoke(nameof(DelayMethod), 3.5f);
    }
    public void ChangeAnswer()
    {
        AnswerUI.text = playeranswer;
    }
    void DelayMethod()
    {
        Rock.SetActive(true);
    }
    public void DelayendMethod()
    {
        Invoke(nameof(DelayMethod2), 2.5f);
    }
    public void DelayMethod2()
    {
        SceneManager.LoadScene("GameMain");
    }
}

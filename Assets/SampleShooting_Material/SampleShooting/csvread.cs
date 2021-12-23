using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;　　　　// 追記

public class csvread : MonoBehaviour
{
    public TextAsset csvFile;   　　　　　// GUIでcsvファイルを割当
　　List<string[]> csvDatas = new List<string[]>(); //ここは参考ブログとは違う
    public Text textUI;

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
        var number = Random.Range(0, 19);
        textUI.text = csvDatas[number][0];

        Debug.Log(csvDatas[number][0]);
        Debug.Log(csvDatas[number][1]);
    }
}

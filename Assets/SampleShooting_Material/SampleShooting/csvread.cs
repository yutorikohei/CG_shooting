using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;�@�@�@�@// �ǋL

public class csvread : MonoBehaviour
{
    public TextAsset csvFile;   �@�@�@�@�@// GUI��csv�t�@�C��������
�@�@List<string[]> csvDatas = new List<string[]>(); //�����͎Q�l�u���O�Ƃ͈Ⴄ
    public Text textUI;
    public string quiz;
    public string answer;
    public int exm;
    public string word;
    public string playeranswer = "";

�@�@�@�@// Use this for initialization
�@�@�@�@void Start()
    {

�@�@�@�@�@�@�@�@// �i�[
�@�@�@�@�@�@�@�@string[] lines = csvFile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (var line in lines)
        {
            if (line == "") { continue; }
            csvDatas.Add(line.Split(','));�@�@�@�@// string[]��ǉ����Ă���
�@�@�@�@�@�@�@�@}

        // �����o��
        var number = Random.Range(1, 2);
        textUI.text = csvDatas[number][0];

        quiz = csvDatas[number][0];
        answer = csvDatas[number][1];
        exm = int.Parse(csvDatas[number][2]);
        word = csvDatas[number][3];
        Debug.Log(quiz);
        Debug.Log(exm);
        Debug.Log(answer);
    }
}

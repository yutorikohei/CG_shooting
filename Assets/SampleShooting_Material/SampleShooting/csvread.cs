using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;�@�@�@�@// �ǋL

public class csvread : MonoBehaviour
{
    public TextAsset csvFile;   �@�@�@�@�@// GUI��csv�t�@�C��������
�@�@List<string[]> csvDatas = new List<string[]>(); //�����͎Q�l�u���O�Ƃ͈Ⴄ
    public Text textUI;

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
        var number = Random.Range(0, 19);
        textUI.text = csvDatas[number][0];

        Debug.Log(csvDatas[number][0]);
        Debug.Log(csvDatas[number][1]);
    }
}
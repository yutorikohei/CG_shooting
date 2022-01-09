using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class RockController : MonoBehaviour {

    private static readonly string[] hira = { "あ", "い", "う", "え", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "が", "ぎ", "ぐ", "げ", "ご", "ざ", "じ", "ず", "ぜ", "ぞ", "だ", "ぢ", "づ", "で", "ど", "ば", "び", "ぶ", "べ", "ぼ", "ぱ", "ぴ", "ぷ", "ぺ", "ぽ", "ゃ", "ゅ", "ょ", "っ" };
    SpriteRenderer sr;
    public Sprite[] hiragana;
    float fallSpeed;
    private SpriteRenderer MainSpriteRenderer;
    public string comment;

    GameObject csvreader;
    GameObject rocket;
    csvread script;

    void Start() {
        csvreader = GameObject.Find("csvreader");
        rocket = GameObject.Find("rocket");
        script = csvreader.GetComponent<csvread>();

        var randomnumber = UnityEngine.Random.Range(0, script.word.Count());
        string check = script.word;
        string check2 = check[randomnumber].ToString();

        int num = Array.IndexOf(hira, check2);
        comment = hira.ElementAt(num);
        
        Debug.Log(comment);
        this.fallSpeed = 0.005f;
        sr = GetComponent<SpriteRenderer>();
        hiragana = Resources.LoadAll<Sprite>("hiragana");
        sr.sprite = hiragana[num+1];

    }
	
	void Update () {
		transform.Translate( 0, -fallSpeed, 0, Space.World);

		if (transform.position.y < -5.5f) {
			Destroy (gameObject);
		}
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        script.playeranswer += comment;
        csvreader.GetComponent<csvread>().ChangeAnswer();
        Debug.Log(script.playeranswer);
        if(script.exm == script.playeranswer.Length)
        {
            if(script.answer != script.playeranswer)
            {
                rocket.GetComponent<RocketController>().clearAccess();
                FadeController.isFadeOut = true;
                csvreader.GetComponent<csvread>().DelayendMethod();
            }
            if(script.answer == script.playeranswer)
            {
                rocket.GetComponent<RocketController>().IclearAccess();
                script.playeranswer = "";
                csvreader.GetComponent<csvread>().ChangeAnswer();
            }
        }
    }
}
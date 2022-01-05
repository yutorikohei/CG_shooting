using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class RockController : MonoBehaviour {

    private static readonly string[] hira = { "‚ ", "‚¢", "‚¤", "‚¦", "‚©", "‚«", "‚­", "‚¯", "‚±", "‚³", "‚µ", "‚·", "‚¹", "‚»", "‚½", "‚¿", "‚Â", "‚Ä", "‚Æ", "‚È", "‚É", "‚Ê", "‚Ë", "‚Ì", "‚Í", "‚Ð", "‚Ó", "‚Ö", "‚Ù", "‚Ü", "‚Ý", "‚Þ", "‚ß", "‚à", "‚â", "‚ä", "‚æ", "‚ç", "‚è", "‚é", "‚ê", "‚ë", "‚í", "‚ð", "‚ñ", "‚ª", "‚¬", "‚®", "‚°", "‚²", "‚´", "‚¶", "‚¸", "‚º", "‚¼", "‚¾", "‚À", "‚Ã", "‚Å", "‚Ç", "‚Î", "‚Ñ", "‚Ô", "‚×", "‚Ú", "‚Ï", "‚Ò", "‚Õ", "‚Ø", "‚Û", "‚á", "‚ã", "‚å", "‚Á" };
    SpriteRenderer sr;
    public Sprite[] hiragana;
    float fallSpeed;
    private SpriteRenderer MainSpriteRenderer;
    public string comment;

    GameObject csvreader;
    csvread script;

    void Start() {
        csvreader = GameObject.Find("csvreader");
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
        Debug.Log(script.playeranswer);
        if(script.exm == script.playeranswer.Length)
        {
            if(script.answer == script.playeranswer)
            {
                script.playeranswer = "";
                SceneManager.LoadScene("GameMain");
            }
            if(script.answer != script.playeranswer)
            {
                script.playeranswer = "";
            }
        }
    }
}
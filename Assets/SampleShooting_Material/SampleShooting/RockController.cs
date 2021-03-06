using UnityEngine;
using System.Linq;
using System.Collections;

public class RockController : MonoBehaviour {

    private static readonly string[] hira = new string[] { "あ", "い", "う", "え", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "が", "ぎ", "ぐ", "げ", "ご", "ざ", "じ", "ず", "ぜ", "ぞ", "だ", "ぢ", "づ", "で", "ど", "ば", "び", "ぶ", "べ", "ぼ", "ぱ", "ぴ", "ぷ", "ぺ", "ぽ", "ゃ", "ゅ", "ょ", "っ" };
    SpriteRenderer sr;
    public Sprite[] hiragana;
    float fallSpeed;
    float rotSpeed;
    private SpriteRenderer MainSpriteRenderer;

    void Start() {
        string comment = hira.ElementAt(Random.Range(0, hira.Count()));
        Debug.Log(comment);
        this.fallSpeed = 0.01f + 0.01f * Random.value;
		this.rotSpeed = 5f + 3f * Random.value;
        sr = GetComponent<SpriteRenderer>();
        hiragana = Resources.LoadAll<Sprite>("hiragana");
        sr.sprite = hiragana[5];

    }
	
	void Update () {
		transform.Translate( 0, -fallSpeed, 0, Space.World);

		if (transform.position.y < -5.5f) {
			Destroy (gameObject);
		}
	}
}
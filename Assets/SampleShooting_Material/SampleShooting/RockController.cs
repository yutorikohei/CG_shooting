using UnityEngine;
using System.Linq;
using System.Collections;

public class RockController : MonoBehaviour {

    private static readonly string[] hira = new string[] { "‚ ", "‚¢", "‚¤", "‚¦", "‚©", "‚«", "‚­", "‚¯", "‚±", "‚³", "‚µ", "‚·", "‚¹", "‚»", "‚½", "‚¿", "‚Â", "‚Ä", "‚Æ", "‚È", "‚É", "‚Ê", "‚Ë", "‚Ì", "‚Í", "‚Ð", "‚Ó", "‚Ö", "‚Ù", "‚Ü", "‚Ý", "‚Þ", "‚ß", "‚à", "‚â", "‚ä", "‚æ", "‚ç", "‚è", "‚é", "‚ê", "‚ë", "‚í", "‚ð", "‚ñ", "‚ª", "‚¬", "‚®", "‚°", "‚²", "‚´", "‚¶", "‚¸", "‚º", "‚¼", "‚¾", "‚À", "‚Ã", "‚Å", "‚Ç", "‚Î", "‚Ñ", "‚Ô", "‚×", "‚Ú", "‚Ï", "‚Ò", "‚Õ", "‚Ø", "‚Û", "‚á", "‚ã", "‚å", "‚Á" };
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
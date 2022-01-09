using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RocketController : MonoBehaviour {

	public GameObject bulletPrefab;
    public GameObject explosionPrefab;

    GameObject csvreader;

    public AudioClip Ca;
    public AudioClip Ia;
    AudioSource audioSource;

    void Start ()
    {
        csvreader = GameObject.Find("csvreader");
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.005f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate ( 0.005f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
            Instantiate (bulletPrefab, transform.position, Quaternion.identity);
        }
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        // 爆発エフェクトを生成する	
        if (coll.gameObject.name == "Rockprefab(Clone)")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(coll.gameObject);
            Destroy(gameObject);
            csvreader.GetComponent<csvread>().DelayendMethod();
        }
    }

    public void clearAccess()
    {
        audioSource.PlayOneShot(Ca);
    }
    public void IclearAccess()
    {
        audioSource.PlayOneShot(Ia);
    }
}
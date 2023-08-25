using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	float x,y;
	public GameObject bankhijaiyah;
	public int kontrol;
	// Use this for initialization
	void Start () {
		x = transform.localScale.x;
		y = transform.localScale.y;
		
	}

	void OnMouseDown() {
		GetComponent <AudioSource> ().Play ();
		transform.localScale = new Vector2 (x*1.2f, y/1.2f);

	}

	void OnMouseUp () {
		transform.localScale = new Vector2 (x, y);

		bankhijaiyah.GetComponent<bank_hijaiyah> ().control(kontrol);
	
	}

	// Update is called once per frame
	void Update () {
		
	}
}

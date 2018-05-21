using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

	public Slider BarraDeVida;
	float healthplayer = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		
		if (coll.collider.gameObject.tag == "Chaser") {
			healthplayer = healthplayer - 0.1f;
			BarraDeVida.value = healthplayer;
		}

		if (coll.collider.gameObject.tag == "Arana") {
			
			healthplayer = healthplayer - 0.05f;
			BarraDeVida.value = healthplayer;
		}
	}
}
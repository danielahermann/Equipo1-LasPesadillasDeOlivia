using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

	public Scrollbar BarraDeVida;
	public float healthplayer ;
	public float ValorQuitaVida;
	public float ValorDaVida;
	public GameObject pierde;
	public GameObject Gana;


	public float ValorVidaBarra;

	public GameObject LuzAzul;

	GameObject PocimaAzul;
	 GameObject PocimaRosada;
	 GameObject PocimaVerde;

	PersonajeMovimientos CaminaBien;
	PersonajeCambioControles TomoPosionVerde;

	public bool RecogeLlave;

	void Update ()
	{
		CaminaBien = GameObject.Find ("OliviaFrente 1").GetComponent<PersonajeMovimientos> ();
		TomoPosionVerde  = GameObject.Find ("OliviaFrente 1").GetComponent<PersonajeCambioControles> ();

		PocimaAzul= GameObject.FindGameObjectWithTag ("Azul");
		PocimaRosada= GameObject.FindGameObjectWithTag ("Rosado");
		PocimaVerde= GameObject.FindGameObjectWithTag ("Verde");

	}


	void OnCollisionEnter2D(Collision2D coll) {


		
		if (coll.collider.gameObject.tag == "Chaser") {
			healthplayer -= ValorQuitaVida;
			BarraDeVida.size = healthplayer/100;
		}

		if (coll.collider.gameObject.tag == "Arana") {
			
			healthplayer -= ValorQuitaVida;
			BarraDeVida.size = healthplayer/100;
		}

		if (healthplayer <= 0f) {
		
			pierde.SetActive (true);
			//Time.timeScale = 0f;
		
		}
		if (coll.collider.gameObject.tag == "Rosado") {

			Destroy (PocimaRosada);
			healthplayer += ValorDaVida;
			BarraDeVida.size = BarraDeVida.size + ValorVidaBarra;
		}

		if (coll.collider.gameObject.tag == "Azul") {

			Destroy (PocimaAzul);
			LuzAzul.SetActive (true);
			StartCoroutine("DesapareceOscuridad");
		}

		if (coll.collider.gameObject.tag == "Verde") {

			Destroy (PocimaVerde);
			CaminaBien .enabled =false;
			TomoPosionVerde.enabled = true;

			StartCoroutine ("VuelveControlesALaNormalidad");
		}

		if (coll.collider.gameObject.tag == "Llave") {

			RecogeLlave = true;
		}

		if (coll.collider.gameObject.tag == "FinalPuerta" && RecogeLlave == true) {
			
				Gana.SetActive (true);

		}

	}


	IEnumerator VuelveControlesALaNormalidad()
	{
		yield return new WaitForSeconds (10f);
		CaminaBien .enabled =true;
		TomoPosionVerde.enabled = false;

	}

	IEnumerator DesapareceOscuridad()
	{
		yield return new WaitForSeconds (15f);
		LuzAzul.SetActive (false);
	
	}

}
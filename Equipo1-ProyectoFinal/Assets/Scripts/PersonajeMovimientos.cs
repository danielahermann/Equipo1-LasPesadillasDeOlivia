using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMovimientos : MonoBehaviour {

	public float Speed;
	public Animator OliviaAnimator;
	// Use this for initialization

	private Rigidbody2D rb2d;
	void Start () {
		OliviaAnimator= gameObject.GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		float MovimientoX = inputX * Speed * Time.deltaTime;
		float MovimientoY = inputY * Speed * Time.deltaTime;
		transform.Translate(MovimientoX,MovimientoY,0);
		//Vector2 movimiento = new Vector2 (MoviemientoX,MovimientoY);

		//rb2d.AddForce (movimiento * Speed * Time.deltaTime);
		// Mueve personaje hacia arriba

		if (Input.GetKeyDown(KeyCode.W))
		{
			OliviaAnimator.SetTrigger("CaminaArriba");

		}

		/*if (Input.GetKey(KeyCode.W))
		{
			
			this.gameObject.transform.Translate (0,Speed,0);
		}*/


		if (Input.GetKeyUp(KeyCode.W))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		// Mueve personaje hacia Derecha

		if (Input.GetKeyDown(KeyCode.D))
		{
			OliviaAnimator.SetTrigger("CaminaDerecha");

		}

		/*if (Input.GetKey(KeyCode.D))
		{
			
			this.gameObject.transform.Translate (Speed,0,0);
		}*/


		if (Input.GetKeyUp(KeyCode.D))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		// Mueve personaje hacia Izquierda

		if (Input.GetKeyDown(KeyCode.A))
		{
			OliviaAnimator.SetTrigger("CaminaIzquierda");

		}

		/*if (Input.GetKey(KeyCode.A))
		{
			
			this.gameObject.transform.Translate (-Speed,0,0);
		}*/

		if (Input.GetKeyUp(KeyCode.A))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		// Mueve personaje hacia abajo

		if (Input.GetKeyDown(KeyCode.S))
		{
			OliviaAnimator.SetTrigger("CaminaAbajo");

		}

		/*if (Input.GetKey(KeyCode.S))
		{
			
			this.gameObject.transform.Translate (0,-Speed,0);
		}*/

		if (Input.GetKeyUp(KeyCode.S))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		//El personaje se agacha

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			OliviaAnimator.SetTrigger ("Agachar");
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			OliviaAnimator.SetTrigger("VolverDePie");
			OliviaAnimator.SetTrigger("Quieta");
		}

	}

}

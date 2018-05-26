using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCambioControles : MonoBehaviour {

	public float Speed;
	public Animator OliviaAnimator;



	// Use this for initialization


	void Start () {
		OliviaAnimator= gameObject.GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void FixedUpdate () {


		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		float MovimientoX = -inputX * Speed * Time.deltaTime;
		float MovimientoY = -inputY * Speed * Time.deltaTime;
		transform.Translate(MovimientoX,MovimientoY,0);


		if (Input.GetKeyDown(KeyCode.S))
		{
			print ("Oprime w");
			OliviaAnimator.SetTrigger("CaminaArriba");

		}

	
		if (Input.GetKeyUp(KeyCode.S))
		{
			print ("dejé de oprimir w");
			OliviaAnimator.SetTrigger("Quieta");
		}

		// Mueve personaje hacia Derecha

		if (Input.GetKeyDown(KeyCode.A))
		{
			OliviaAnimator.SetTrigger("CaminaDerecha");

		}


		if (Input.GetKeyUp(KeyCode.A))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		// Mueve personaje hacia Izquierda

		if (Input.GetKeyDown(KeyCode.A))
		{
			OliviaAnimator.SetTrigger("CaminaIzquierda");

		}


		if (Input.GetKeyUp(KeyCode.A))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		// Mueve personaje hacia abajo

		if (Input.GetKeyDown(KeyCode.W))
		{
			OliviaAnimator.SetTrigger("CaminaAbajo");

		}

		if (Input.GetKeyUp(KeyCode.W))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}

		//El personaje se agacha

		/*if (Input.GetKeyDown (KeyCode.Space)) 
		{
			OliviaAnimator.SetTrigger ("Agachar");
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			OliviaAnimator.SetTrigger("Quieta");
		}*/

	}

}

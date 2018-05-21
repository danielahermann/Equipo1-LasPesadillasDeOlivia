using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSigue : MonoBehaviour {

	public float visionRadio;
	public float speed;

	//variable para guardar al jugador
	GameObject Jugador;

	//Variable para guardar la posicion incial del enemigo
	Vector3 PosicionInicial;

	// Use this for initialization
	void Start () {

		//Tag del jugador
		Jugador = GameObject.FindGameObjectWithTag ("Player");

		//Guarda la posición incial del enemigo
		PosicionInicial= transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// Siempre guarde la posicion incial del enemigo
		Vector3 target = PosicionInicial;

		float Distancia = Vector3.Distance (Jugador.transform.position, transform.position );

		//samos la posicion al jugador que debe seguir
		if (Distancia < visionRadio ) target =Jugador.transform.position;

		//Mueve el enemigo al jugador y le damos la velocidad
		float fixedSpeed = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target, fixedSpeed);

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.black;
		Gizmos.DrawWireSphere (transform.position,visionRadio);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour {


	public GameObject LlaveCanvas;
	public GameObject LlaveJuego;
	public bool TieneLlave;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnCollisionEnter2D (Collision2D other)
	{
		if (other.collider.gameObject.tag == "Player")
		{
			Destroy (LlaveJuego);	
			TieneLlave = true;
			LlaveCanvas.SetActive (true);
		}
		
	}
}

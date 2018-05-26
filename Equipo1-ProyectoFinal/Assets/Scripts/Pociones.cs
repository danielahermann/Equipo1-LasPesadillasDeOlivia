using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pociones : MonoBehaviour {


	//public GameObject MensajePocionCanvas;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Collider2D>().gameObject.tag == "Player")
		{
			Destroy (this.gameObject);	

			//MensajePocionCanvas.SetActive (true);
		}



	}
}

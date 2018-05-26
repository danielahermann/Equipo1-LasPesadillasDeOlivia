using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaMensajesPociones : MonoBehaviour {


	public GameObject mensajeAzul;
	public GameObject mensajeVerde;
	public GameObject mensajeRosa;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Collider2D>().gameObject.tag == "Azul")
		{
			mensajeAzul.SetActive (true);
			StartCoroutine ("DesapareceMensaje");
		}

		if (other.GetComponent<Collider2D>().gameObject.tag == "Verde")
		
		{
			mensajeVerde.SetActive (true);
			StartCoroutine ("DesapareceMensaje");
		}

		if (other.GetComponent<Collider2D>().gameObject.tag == "Rosado")
		{
			mensajeRosa.SetActive (true);
			StartCoroutine ("DesapareceMensaje");
		}



			
	}

	IEnumerator DesapareceMensaje ()
	{
		yield return new WaitForSeconds (2.0f);
		mensajeAzul.SetActive  (false);
		mensajeRosa .SetActive  (false);
		mensajeVerde.SetActive  (false);
	}
}

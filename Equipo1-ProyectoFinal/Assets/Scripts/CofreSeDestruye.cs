using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreSeDestruye : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D Other)
	{
		if (Other.GetComponent<Collider2D>().gameObject.tag == "DestruyeCofre")
		{
			Destroy (this.gameObject);
		}
	}
}

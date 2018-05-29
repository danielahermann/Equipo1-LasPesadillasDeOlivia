using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Pocion : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Collider2D>().gameObject.tag == "Verde")
        {
            GetComponent<AudioSource>().Play();
        }
        if (other.GetComponent<Collider2D>().gameObject.tag == "Azul")
        {
            GetComponent<AudioSource>().Play();
        }
        if (other.GetComponent<Collider2D>().gameObject.tag == "Rosado")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
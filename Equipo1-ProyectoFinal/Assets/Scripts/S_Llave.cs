using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Llave : MonoBehaviour
{
    public float num;
    public GameObject trigger;
    public AudioSource audioClip;

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
        if (other.GetComponent<Collider2D>().gameObject.tag == "Llave")
        {
            trigger.SetActive(true);
            audioClip.Play();

        }
    }
}

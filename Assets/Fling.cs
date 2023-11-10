using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fling : MonoBehaviour
{
    public AudioSource GuitarRiff;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        rb.AddForce(-50,50,0);
        GuitarRiff.Play();
    }


  


}

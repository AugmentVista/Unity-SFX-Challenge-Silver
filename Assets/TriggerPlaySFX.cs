using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource Grass;

    private void OnTriggerEnter(Collider other)
    {
        Grass.Play();


    }

    private void OnTriggerExit(Collider other)
    {
        Grass.Pause();
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DetectorMusic : MonoBehaviour
{
    private AudioSource source;
    private bool canPlay = true;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    //Dectection si un objet est en contacte.
    private void OnTriggerEnter(Collider other)
    {
        if (canPlay)
        {
            //Jouer le son
            source.Play();
            canPlay = false;
        }

    }

    //Dectection si l'objet est sorti.
    private void OnTriggerExit(Collider other)
    {
        if(canPlay == false)
        {
            canPlay = true;
        }
    }
}

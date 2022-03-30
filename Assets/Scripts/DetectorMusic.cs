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
    private void OnTriggerEnter(Collider other)
    {
        if (canPlay)
        {
            Debug.Log("TriggerEnter");
            source.Play();
            canPlay = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(canPlay == false)
        {
            canPlay = true;
        }
    }
}

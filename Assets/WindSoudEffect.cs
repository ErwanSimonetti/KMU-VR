using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WindSoudEffect : MonoBehaviour
{
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

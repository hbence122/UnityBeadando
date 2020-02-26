using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    AudioSource audio;
    bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {


            if (isPlaying == true)
            {
                audio.Stop();
                isPlaying = false;
            }
            else
            {
                audio.Play();
                isPlaying = true;
            }
        }
        
    }
}

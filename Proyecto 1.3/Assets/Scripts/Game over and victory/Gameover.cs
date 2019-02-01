using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {

    public AudioClip gameover1;
  

    AudioSource reproductor;
   

    // Use this for initialization
    void Start ()
    {
        reproductor = GetComponent<AudioSource>();
        
        fondo();


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void fondo()
    {
        reproductor.volume = GameManager.volmusic;
        reproductor.clip = gameover1;
        reproductor.Play();

       
    }

 
}

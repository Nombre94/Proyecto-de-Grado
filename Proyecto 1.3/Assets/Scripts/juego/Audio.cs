﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour {

    public AudioClip juego1;
    public AudioClip juego2;
    public AudioClip juego3;


    AudioSource reproductor;

    private float random;

    // Use this for initialization
    void Start () {

        random = 0;
        reproductor = GetComponent<AudioSource>();
        reproductor.volume = GameManager.volmusic;

        random = Random.Range(1, 4);

        // aqui se escoge que cancion se tocara

        if (random == 1)
        {
            reproductor.clip = juego1;
        }
        if (random == 2)
        {
            reproductor.clip = juego2;
        }
        if (random == 3)
        {
            reproductor.clip = juego3;
        }

        reproductor.Play();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

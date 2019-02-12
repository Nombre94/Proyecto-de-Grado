using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// este script es el encargado de la funcionalidad de la pantalla de gameover 
public class Gameover : MonoBehaviour {

    public AudioClip gameover1; // esta es la variable que contendra la musica que se reproducira 
  

    AudioSource reproductor;//esta variable en es llamado a un componente propio del objeto
   

    // al inicializar la pantalla de game over se establece el componente y se llama a la funcio que ejecutara la musica de fondo
    void Start ()
    {
        reproductor = GetComponent<AudioSource>();
        
        fondo();


    }

    // al ejecutarse esta clase se carga el volumen que el usuario tiene establecido y se selecciona
    //el fondo sonoro y se reproduce
    void fondo()
    {
        reproductor.volume = PlayerPrefs.GetFloat("volumen", 1); 
        reproductor.clip = gameover1;
        reproductor.Play();

       
    }

 
}

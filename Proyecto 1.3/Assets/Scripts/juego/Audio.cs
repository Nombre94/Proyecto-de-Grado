using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// este script es el encargado de reproducir la musica de la pantalla de  juego 
public class Audio : MonoBehaviour {

    // se establecer las variables que contendran los diferentes fondos sonoros que se usaran 
    public AudioClip juego1;
    public AudioClip juego2;
    public AudioClip juego3;

    
    AudioSource reproductor;

    // se crea una variable que determinara el volumen musical y la velocidad
    public Slider volumen;
    

    // se crea una variable random que determinaa que fondo musical se usara
    private float random;


    // al inicializar el script se establece la variable random con un randomico entre 1 y 4 ademas de determinar el componete de audio 
    // y caragra el volumen establecido 
    void Start () {

        
        reproductor = GetComponent<AudioSource>();
     
        volumen.value = PlayerPrefs.GetFloat("volumen", 1);

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
	
	// en esta clase se va recogiendo constante mente el valor de la variable volumen para prevenir posibles 
    // cambios que el usuario le haga a mitad de juego
	void Update () {

        reproductor.volume = volumen.value;
        GameManager.volmusic = volumen.value;
        PlayerPrefs.SetFloat("volumen", GameManager.volmusic);
    }
}

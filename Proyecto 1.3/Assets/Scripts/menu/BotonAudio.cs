using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BotonAudio : MonoBehaviour {

   
    private int x = 0; // determinarea en que imagen esta

    // con esto agregamos los clip de audio
    public AudioClip menu1;
    public AudioClip menu2;
    public AudioClip menu3;
    public AudioClip menu4;

    //donde se reproduce el sonido
    AudioSource reproductor;

    private float random;

    // para el slider 

    public Slider volumen;



    // Use this for initialization
    void Start ()
    {
        random = 0;
        reproductor = GetComponent<AudioSource>();

        // esta parte es para verificar si se hizo algun cambio del volumen en el juego 
        if (GameManager.volmusic>0)
        {
            volumen.value = GameManager.volmusic;
        }
        

        random = Random.Range(1, 5);

        // aqui se escoge que cancion se tocara

        if (random == 1)
        {
            reproductor.clip = menu1;
        }
        if (random == 2)
        {
            reproductor.clip = menu2;
        }
        if (random == 3)
        {
            reproductor.clip = menu3;
        }
        if (random == 4)
        {
            reproductor.clip = menu4;
        }

        reproductor.Play();

    }

	// Update is called once per frame
	void Update ()
    {
        reproductor.volume = volumen.value;
        GameManager.volmusic = volumen.value;

    }

    public void click () // en esta clase eliminamos y ponemos el audio
    {

        if (x == 0)
        {
            x = 1;
            
            reproductor.Pause();
        }else
        {
            x = 0;
            
            reproductor.Play();
        }

    }

   

//  public float musicVolume = 1f;
//
//	// Update is called once per frame
//	void Update () {
//
//        // Setting volume option of Audio Source to be equal to musicVolume
//        reproductor.volume = musicVolume;
//	}
//
//    // Method that is called by slider game object
//    // This method takes vol value passed by slider
//    // and sets it as musicValue
//    public void SetVolume(float vol)
//    {
//        musicVolume = vol;
//    }

}

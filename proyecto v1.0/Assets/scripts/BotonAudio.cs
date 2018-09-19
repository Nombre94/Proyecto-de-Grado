using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonAudio : MonoBehaviour {

    public Image UIimagen;
    private int x = 0; // determinarea en que imagen esta

    // con esto agregamos los clip de audio
    public AudioClip menu1;
    public AudioClip menu2;
    public AudioClip menu3;
    public AudioClip menu4;

    //donde se reproduce el sonido
    AudioSource reproductor;

    private float random;


    // Use this for initialization
    void Start ()
    {
        random = 0;
        reproductor = GetComponent<AudioSource>();
        UIimagen = GameObject.Find("sonido").GetComponent<Image>();
        UIimagen.sprite = Resources.Load<Sprite>("sprites/S1");

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


    }

    public void click () // en esta clase eliminamos y ponemos el audio
    {

        if (x == 0)
        {
            x = 1;
            UIimagen.sprite = Resources.Load<Sprite>("sprites/S2");
            reproductor.Pause();
        }else
        {
            x = 0;
            UIimagen.sprite = Resources.Load<Sprite>("sprites/S1");
            reproductor.Play();
        }

    }

    public void irescenaopciones()
    {
        SceneManager.LoadScene("menuopciones");
    }

    public void irescenaseleccion()
    {
        SceneManager.LoadScene("menuselecion");
    }

    public void irescenaseleccionjuego()
    {
        SceneManager.LoadScene("seleccionjuego");
    }
    public void Atras1()
    {
        SceneManager.LoadScene("menuprincipal");
    }
    public void Atras2()
    {
        SceneManager.LoadScene("menuselecion");
    }

    public void quitar()
    {
        Application.Quit();

        Debug.Log("salir");
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

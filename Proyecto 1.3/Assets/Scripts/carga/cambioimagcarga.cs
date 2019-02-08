using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class cambioimagcarga : MonoBehaviour {

    public Image imagen;

    int x;
	// Use this for initialization
	void Start ()
    {
        x = 0;
        imagen = GameObject.Find("imagen").GetComponent<Image>();
        cambioimagen();
		
	}
	
	void cambioimagen()
    {
        if (x== 0)
        {
            imagen.sprite = Resources.Load<Sprite>("sprites/carga/manos");
            x = x + 1;
            Invoke("cambioimagen", 5);
        }
        else
        {
            imagen.sprite = Resources.Load<Sprite>("sprites/carga/teclas");
            Invoke("juego", 5);
        }
    }

    void juego()
    {
        SceneManager.LoadScene("juego");
    }
}

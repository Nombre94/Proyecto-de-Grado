using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class cambioimagcarga : MonoBehaviour {

    public Image imagen; // es la variable de tipo imagen la ual contendra a la imagen que se mostrara en cada momento

    int x;// es la variable que determinara la imagen que se debe ostrar 

	// Use this for initialization

    // se inicializan las variables y se da paso a el proceso d4e muestra y cambio de imagen 
	void Start ()
    {
        x = 0;
        imagen = GameObject.Find("imagen").GetComponent<Image>();
        cambioimagen();
		
	}

	// en esta clase se determina la imagen que se muestra por medio de la variable X, y determinadonde una imagen respectiva 
    
	void cambioimagen()
    {
        // en esta primera parte se confirma que es la primera ves que se ejecuta esta parte del programa y se muestra la primer imagen 
        // luego se reinvoca esta misma clase con un espacio de tiempo de  segundos
        if (x== 0)
        {
            imagen.sprite = Resources.Load<Sprite>("sprites/carga/manos");
            x = x + 1;
            Invoke("cambioimagen", 5);
        }
        //al no ser la primera ves que se ejecuta pasa a esta parte donde se muestra la segundo imagen y luego se llama a otra clase 
        // con un desfaz de  segundos tambien
        else
        {
            imagen.sprite = Resources.Load<Sprite>("sprites/carga/teclas");
            Invoke("juego", 5);
        }
    }

    // en esta clase se hace el paso de la pantalla de carga a la pantalla de juego como tal
    void juego()
    {
        SceneManager.LoadScene("juego");
    }
}

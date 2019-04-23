using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// este script es el encargado de manejar los cambios de escenas en las pantallas de menu, juego y pantallas finales 
public class CambioDeEscena : MonoBehaviour {

    // es enta primer clase si el usuario presiona alguno de los 3 primeros niveles se le dijire al juego con el nivel basico
    public void niveli1()
    {
        GameManager.nivel = 0;
        GameManager.borrado = 0;
        GameManager.velocidad = 6;
        SceneManager.LoadScene("carga");
    }
    public void niveli2()
    {
        GameManager.nivel = 0;
        GameManager.borrado = 1;
        GameManager.velocidad = 6;
        SceneManager.LoadScene("carga");
    }
    public void niveli3()
    {
        GameManager.nivel = 0;
        GameManager.borrado = 1;
        GameManager.velocidad = 7;
        SceneManager.LoadScene("carga");
    }

    // esta clase se ejecuta cuando selecciona los 2 utimos niveles pasandolo a la pantalla de juego con el nivl avanzado
    public void nivels4()
    {
        GameManager.nivel = 1;
        GameManager.borrado = 1;
        GameManager.velocidad = 8;
        SceneManager.LoadScene("carga");
    }

    public void nivels5()
    {
        GameManager.nivel = 1;
        GameManager.borrado = 1;
        GameManager.velocidad = 9;
        SceneManager.LoadScene("carga");
    }

    // esta se ejecuta cuando en la pantalla final el usuario da reset y lo que hace es reenviarlo de nuevo a la pantalla de juego 
    // con el nivel previmente establecido
    public void reset()
    {
        SceneManager.LoadScene("carga");
    }

    //esta clase es la encargada de pasarlo al menu principal en cualquier momento que el usuario lo desee
    public void Menu()
    {
        
        SceneManager.LoadScene("Menu");
    }

    public void Evaluacion()
    {

        SceneManager.LoadScene("Evaluacion");
    }
}

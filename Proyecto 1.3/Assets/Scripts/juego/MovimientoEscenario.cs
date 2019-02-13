using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// este script es el encargado de dro de juego
public class MovimientoEscenario : MonoBehaviour {

     float vel;
     float des = -23.59f; // posicion donde se detruyen los escenarios y obstaculos


    private void Start()
    {
        vel = GameManager.velocidad;
    }
    // en esta funcion se va modificando la poscicion de las partes del escenario de forma continua y a una velocidad determiada 
    // ademas de determinar si en objeto ya salio del campo visual del ussuario para asi destruirlo 
    void Update () {

        transform.Translate(-vel * Time.deltaTime, 0, 0);

        if (transform.position.x <des)
        {
            Destroy(gameObject);
        }

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// este script es e encargado de la creacion de los obstaculos
public class CreacionDeObstaculos : MonoBehaviour {

    public GameObject[] obj;// este array contendra todos los obstaculos que se usaran 

    // estas son las variables que determina que obstaculo crear 
    float z = 0f;
    float y = 0f;
    int x = 0;
    int contador;
    private int inicio;

	// al inicializarse llo unico que hace es hacer el llamado a la funcion generar
	void Start ()
    {

        inicio = 0;
        Generar();
    }
	
	// en esta parte se va escogiendo un numero diferente paulatinamente por medio de un randomico para determinar uno 
    // de los tipos de obstaculos que se usaran 
	void Update ()
    {

        y = Random.Range(0, 2);
  

    }

    // esta funcion es la encargada de seleccionar el obstaculo a utilizar
    void Generar()
    {
        if (inicio == 0 || GameManager.muerte == 1)
        {
            if (GameManager.muerte == 1)
            {
                z = 3;
            }
            else
            {
                inicio = 1;
                Invoke("Generar", GameManager.delayobs);
            }
           

        }
        else
        {

            //dependiendo de la variable z se determina primero si el obstaculo es alto o terrestre 
            if (z == 0)
            {
                //luego se determina si el espacio donde se va a crear es el correspondiente y si lo es se procede a la creacion del mismo
                if (gameObject.layer == 12)
                {
                    Instantiate(obj[0], transform.position, Quaternion.identity);
                }

                // una vez terminada se guarda un tipo de accion determinado por el obstaculo que se creo


                z = 1;
            }

            // si no es alto pasa a selecionar el tipo de obstaculo terrestre
            else
            {

                z = 0;


                // se verifica si es el espacio donde se va a crear es el correcto
                if (gameObject.layer == 13)
                {
                    // y por medio de la variable Y se determina el tipo de obstaculo terrestre que se usara 
                    if (y == 0)
                    {
                        Instantiate(obj[1], transform.position, Quaternion.identity);

                    }
                    else
                    {
                        Instantiate(obj[2], transform.position, Quaternion.identity);

                    }


                }


            }

            // por ultimo se crea en un espacio determinado un objeto especial el cual sera el encargado de ejecutar las acciones 
            // que se determinaron 
            if (gameObject.layer == 16)
            {
                Instantiate(obj[3], transform.position, Quaternion.identity);
 
            }

            contador = contador + 2;
            // luego de toda la ejecucion se reinvoca esta misma funcion con un desfaz entre cada obstaculo
            if (contador < 35 & GameManager.muerte == 0)
            {
                Invoke("Generar", GameManager.delayobs);
            }
            else
            {
                GameManager.final = 1;
            }


        }
    }

  
}

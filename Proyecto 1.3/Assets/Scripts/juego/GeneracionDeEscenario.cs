using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// este script se encarga de la creacion del escenario de juego
public class GeneracionDeEscenario : MonoBehaviour {

    public GameObject[] obj;// este array contendra los objetos para la construccion del escenario 
    float x = 0;

	// al inicializar se determina si el espacio donde se encuentra es para la creacion de techo o piso y se envia 
    // a la funcion determinada
	void Start ()
    {
        if (gameObject.layer== 11)
        {
            GenerarTecho();
        }
        else
        {
            GenerarPiso();
        }
		
	}


    // si se establece que se va a generar el techo se ejecuta esta funcion
    void GenerarTecho()
    {
        //primero se determina que tio de los dos techos existentes se quiere crear y al tenerlo determinado se crea y se cambia la variable
        // de criterio para ir intercalando la creacion entre ambos tipos de techo
        if (x==0)
        {
            Instantiate(obj[0], transform.position, Quaternion.identity);
            x = 1;
        }
        else
        {
            Instantiate(obj[1], transform.position, Quaternion.identity);
            x = 0;
        }

        //luego de su cracion se reinvoca esta misma funcio con un desfaz determinado
        
        if (GameManager.velocidad < 8)
        {
            Invoke("GenerarTecho", 2);
        }
        else
        {
            Invoke("GenerarTecho", 1);
        }
        
        
    }


    // si se quiere generar piso se ejecuta esta funcion que consta solo de la creacion del piso y la reinvocacion de la misma
    void GenerarPiso()
    {
        Instantiate(obj[2], transform.position, Quaternion.identity);

        if (GameManager.velocidad < 8)
        {
            Invoke("GenerarPiso", 2);
        }
        else
        {
            Invoke("GenerarPiso", 1);
        }
    }

    
}

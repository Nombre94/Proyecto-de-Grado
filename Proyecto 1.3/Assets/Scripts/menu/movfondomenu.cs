using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// este script se encarga del movimiento del fondo del menu
public class movfondomenu : MonoBehaviour {

    public float speed = -2f;          // la velocidad del fondo 
    private float posreini = -24.21f; //la posicion donde se reinicia
    private float posini = 79.9f;      // donde aparece de nuevo 

	// en esta funcionse va tranformando la poscicion del fondo paulatinamente y a una velocidad determinada 
	void Update ()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);

        if (transform.position.x < posreini)
        {
            transform.position = new Vector3(posini, 0, 0);

        }

    }
}

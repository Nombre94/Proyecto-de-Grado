using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movopciones : MonoBehaviour {

    public float speed = -2f;          // la velocidad del fondo 
    private float posreini = -14.9f; //la posicion donde se reinicia
    private float posini = 14.7f;      // donde aparece de nuevo 

                                        
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.x < posreini)
        {
            transform.position = new Vector3(posini, 0, 0);

        }


    }
}

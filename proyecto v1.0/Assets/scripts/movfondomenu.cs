using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movfondomenu : MonoBehaviour {

    public float speed = -2f;          // la velocidad del fondo 
    private float posreini = -24.21f; //la posicion donde se reinicia
    private float posini = 80.28f;      // donde aparece de nuevo 



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);

        if (transform.position.x < posreini)
        {
            transform.position = new Vector3(posini, 0, 0);

        }

    }
}

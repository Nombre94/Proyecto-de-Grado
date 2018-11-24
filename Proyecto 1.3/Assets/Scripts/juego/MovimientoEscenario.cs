using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEscenario : MonoBehaviour {

    public float vel;
     float des = -23.59f; // posicion donde se detruyen los escenarios y obstaculos

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(-vel * Time.deltaTime, 0, 0);

        if (transform.position.x <des)
        {
            Destroy(gameObject);
        }

    }
}

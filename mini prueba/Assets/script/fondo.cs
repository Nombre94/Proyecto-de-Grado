using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondo : MonoBehaviour
{

    //public float speed = 1.5f;
    // Vector2 Fondopos;
    private float x = -25.5f;
    private float x2 = 25f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(-0.25f, 0, 0);
       
        if (transform.position.x < x)
        {
           transform.position =new Vector3(x2, 0, 0);
            
        }
		
	}

    //void MoveFondo()
    //{
    //    Fondopos = new Vector2(Time.time * speed, 0);
    //
    //    GetComponent<Renderer>().material.mainTextureOffset = Fondopos;
   // }
}

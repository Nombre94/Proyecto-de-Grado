using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tecleo : MonoBehaviour {
    public GameObject[] obj;
    string name;
    float layer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

      if(Input.GetKeyDown("q"))
        {
            name = "q";
            layer = 14;
            generar();

            
        }
        if (Input.GetKeyDown("w"))
        {
            name = "w";
            layer = 14;
            generar();

            
        }

    }

    void generar()
    {
        
        if (gameObject.name == name)
        {
            
            if (gameObject.layer == layer)
            {
                
                Instantiate(obj[0], transform.position, Quaternion.identity);

              
            }
           
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneracionDeEscenario : MonoBehaviour {

    public GameObject[] obj;
    float x = 0;

	// Use this for initialization
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
	
	// Update is called once per frame
	void Update ()
    {

		
	}

    void GenerarTecho()
    {
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

        Invoke("GenerarTecho", 2);
        
    }

    void GenerarPiso()
    {
        Instantiate(obj[2], transform.position, Quaternion.identity);

        Invoke("GenerarPiso", 2);
    }

    
}

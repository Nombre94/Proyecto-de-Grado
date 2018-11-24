using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionDeObstaculos : MonoBehaviour {

    public GameObject[] obj;
    // estas es la variable que determina que obstaculo crear 
    float z= 0f;
    float y = 0f;

	// Use this for initialization
	void Start ()
    {
        Generar();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        y = Random.Range(0, 2);
		
	}

    void Generar()
    {
        if (z== 0)
        {


            if (gameObject.layer== 12)
            {
                Instantiate(obj[0], transform.position, Quaternion.identity);
            }
            z = 1;
        }
        else
        {
            z = 0;

            if (gameObject.layer== 13)
            {
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

        Invoke("Generar", 3);

    }
}

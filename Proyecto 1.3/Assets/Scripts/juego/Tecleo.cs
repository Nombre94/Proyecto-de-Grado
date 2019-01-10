using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tecleo : MonoBehaviour {
    public GameObject[] obj;
    string name;
    float layer;
    float tamaño=26;
    
    string[,] abc;

    // Use this for initialization

    void Start() {
       
        rellenar();
        
    }
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < tamaño; i++)
        {
            if (Input.GetKeyDown(abc[0,i]))
            {
                name = abc[0,i];

                if (abc[1,i] == "uno")
                {
                    layer = 14;
                }

                generar();
                
            }
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

    void rellenar()
    {
        abc = new string[,] { { "q", "w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l",
                                "z","x","c","v","b","n","m"}, 

            { "uno", "uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno","uno"
              ,"uno","uno","uno","uno","uno","uno","uno"} };

      

    }
 

    
}

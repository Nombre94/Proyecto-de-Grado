using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wordinput : MonoBehaviour
{

    public wordmanager wordmanager;

	// Update is called once per frame
	void Update ()
    {
		
        foreach (char letra in Input.inputString)
        {
            wordmanager.Type(letra);
        }
	}
}

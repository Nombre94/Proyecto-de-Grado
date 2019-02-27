using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// en este script se crea la lista de palabras que se mostraran al usuario 
public class Generador : MonoBehaviour
{
    private static string[] lista =  { "uno", "dos", "tres", "cuatro", "cinco" } ;

    public static string GetRandomWord ()
    {
        int random = Random.Range(0, lista.Length);
        string word = lista[random];

        return word;
    }
	
}

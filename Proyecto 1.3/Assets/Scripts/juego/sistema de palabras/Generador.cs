using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// en este script se crea la lista de palabras que se mostraran al usuario 
public class Generador : MonoBehaviour
{
    private static string[,] lista = { { "import", "java.util", "Scanner;", "public", "class", "ParImpar {", "static", "void main", "String[]", "ARGS {", "new Scanner", "(System.in);", "System.", "out.print", "nextInt();", "int numero", "if()", "else {}", "numero == 0", "Scanner Leer" }, 
                                       {"","","","","","","","","","","","","","","","","","","",""}
                                     } ;

    public static string GetRandomWord ()
    {
        int random = Random.Range(0, lista.Length);
        string word = lista[0,random];

        return word;
    }
	
}

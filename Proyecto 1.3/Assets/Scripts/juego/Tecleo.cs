﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//este script es el encargado de iluminar el telado cada ves que se presione una tecla 
public class Tecleo : MonoBehaviour {
    public GameObject[] obj;
    string name;
    float layer;
    float tamaño=26;
    
    string[] abc; // este array contendra las letras bases del teclado
    string[] esp;// este array contendra las letras especiales del teclado 


    int conf=0; // esta variable es para confirmar que ya se presiono una tecla base y no salte a las especiales 
    int x; // esta variable onfirma si se presiono una tecla especial para enviarla a generar
 
   

    // al inicializarse se hace el llamado una funcion de relleno
    void Start() {

        borradas();
        rellenar();
        
    }
	
	// en esta funcion va determinado continuamente que tecla se presiona 
	void Update () {
        conf = 0;

        // se mirra si la tecla presionada es una base o especial 
        for (int i = 0; i < tamaño; i++)
        {
            //al ser una tecla base se determina que tecla es y se envia a la funcion generar
            if (Input.GetKeyDown(abc[i]))
            {
                name = abc[i];             
                layer = 14;                
                conf = 1;
                generar();                
            }           
        }


       if (conf == 0)
        {
            // si es una tecla especial se llama a la funcion de especiales 
            especiales();
        }


    }

    void borradas()
    {
        if (GameManager.borrado==1)
        {
            if (gameObject.tag == "primeras" & GameManager.velocidad >= 6)
            {
                Instantiate(obj[1], transform.position, Quaternion.identity);
            }
            if (gameObject.tag == "segundas" & GameManager.velocidad >=7)
            {
                Instantiate(obj[1], transform.position, Quaternion.identity);
            }
            if (gameObject.tag == "terceras" & GameManager.velocidad >= 8)
            {
                Instantiate(obj[1], transform.position, Quaternion.identity);
            }
            if (gameObject.tag == "cuartas" & GameManager.velocidad >= 9)
            {
                Instantiate(obj[1], transform.position, Quaternion.identity);
            }

        }

    }

    // en esta clase es donde se crea el cuadro de iluminacion al presionr la tecla 

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

    // aca se llena 2 array donde estaran la letras bases del alfabeto y las especiales 
    void rellenar()
    {   
        abc = new string[] {"q", "w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l",
                                "z","x","c","v","b","n","m"} ;

        esp = new string[]  { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", ",", "-", "slash", "delete", "tab" ,"mayus","shif"
                              ,"space","ctrl","alt","enter"} ;
                           

    }

    // aca es donde se determinaran las letras especiales que el usaurio pueda presionar 

    void especiales()
    {
        x = 0;
        if (Input.GetKeyDown(KeyCode.Keypad1) | Input.GetKeyDown(KeyCode.Alpha1))
        {
            x = 1;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) | Input.GetKeyDown(KeyCode.Alpha2))
        {
            x = 2;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) | Input.GetKeyDown(KeyCode.Alpha3))
        {
            x = 3;
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) | Input.GetKeyDown(KeyCode.Alpha4))
        {
            x = 4;
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) | Input.GetKeyDown(KeyCode.Alpha5))
        {
            x = 5;
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) | Input.GetKeyDown(KeyCode.Alpha6))
        {
            x = 6;
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) | Input.GetKeyDown(KeyCode.Alpha7))
        {
            x = 7;
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) | Input.GetKeyDown(KeyCode.Alpha8))
        {
            x = 8;
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) | Input.GetKeyDown(KeyCode.Alpha9))
        {
            x = 9;
        }

        if (Input.GetKeyDown(KeyCode.Keypad0) | Input.GetKeyDown(KeyCode.Alpha0))
        {
            x = 10;
        }

        if (Input.GetKeyDown(KeyCode.Period))
        {
            x = 11;
        }

        if (Input.GetKeyDown(KeyCode.Comma))
        {
            x = 12;
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            x = 13;
        }

        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            x = 14;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            x = 15;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            x = 16;
        }

        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            x = 17;
        }

        if (Input.GetKeyDown(KeyCode.RightShift) | Input.GetKeyDown(KeyCode.LeftShift))
        {
            x = 18;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            x = 19;
        }

        if (Input.GetKeyDown(KeyCode.RightControl) | Input.GetKeyDown(KeyCode.LeftControl))
        {
            x = 20;
        }

        if (Input.GetKeyDown(KeyCode.RightAlt) | Input.GetKeyDown(KeyCode.LeftAlt))
        {
            x = 21;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            x = 22;
        }

        if (x>0)
        {
            name = esp[x-1];           
            layer = 14;            
            generar();
        }

    }

    
}

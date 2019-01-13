using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tecleo : MonoBehaviour {
    public GameObject[] obj;
    string name;
    float layer;
    float tamaño=26;
    
    string[] abc; // este array contendra las letras bases del teclado
    string[] esp;// este array contendra las letras especiales del teclado 


    int conf=0; // esta variable es para confirmar que ya se presiono una tecla base y no salte a las especiales 
    int x; // esta variable onfirma si se presiono una tecla especial para enviarla a generar
 
    // Use this for initialization

    void Start() {
       
        rellenar();
        
    }
	
	// Update is called once per frame
	void Update () {
        conf = 0;

        for (int i = 0; i < tamaño; i++)
        {
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
            especiales();
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

    void especiales ()
    {
        x = 0;
        if (Input.GetKeyDown(KeyCode.Keypad1) | Input.GetKeyDown(KeyCode.Alpha1))
        {
            x = 1;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Keypad2) | Input.GetKeyDown(KeyCode.Alpha2))
            {
                x = 2;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Keypad3) | Input.GetKeyDown(KeyCode.Alpha3))
                {
                    x = 3;
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.Keypad4) | Input.GetKeyDown(KeyCode.Alpha4))
                    {
                        x = 4;
                    }
                    else
                    {
                        if (Input.GetKeyDown(KeyCode.Keypad5) | Input.GetKeyDown(KeyCode.Alpha5))
                        {
                            x = 5;
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.Keypad6) | Input.GetKeyDown(KeyCode.Alpha6))
                            {
                                x = 6;
                            }
                            else
                            {
                                if (Input.GetKeyDown(KeyCode.Keypad7) | Input.GetKeyDown(KeyCode.Alpha7))
                                {
                                    x = 7;
                                }
                                else
                                {
                                    if (Input.GetKeyDown(KeyCode.Keypad8) | Input.GetKeyDown(KeyCode.Alpha8))
                                    {
                                        x = 8;
                                    }
                                    else
                                    {
                                        if (Input.GetKeyDown(KeyCode.Keypad9) | Input.GetKeyDown(KeyCode.Alpha9))
                                        {
                                            x = 9;
                                        }
                                        else
                                        {
                                            if (Input.GetKeyDown(KeyCode.Keypad0) | Input.GetKeyDown(KeyCode.Alpha0))
                                            {
                                                x = 10;
                                            }
                                            else
                                            {
                                               if (Input.GetKeyDown(KeyCode.Period))
                                                {
                                                    x = 11;
                                                }
                                               else
                                                {
                                                    if (Input.GetKeyDown(KeyCode.Comma))
                                                    {
                                                        x = 12;
                                                    }
                                                    else
                                                    {
                                                        if (Input.GetKeyDown(KeyCode.Minus))
                                                        {
                                                            x = 13;
                                                        }
                                                        else
                                                        {
                                                            if (Input.GetKeyDown(KeyCode.Backslash))
                                                            {
                                                                x = 14;
                                                            }    
                                                            else
                                                            {
                                                                if (Input.GetKeyDown(KeyCode.Backspace))
                                                                {
                                                                    x = 15;
                                                                }
                                                                else
                                                                {
                                                                    if (Input.GetKeyDown(KeyCode.Tab))
                                                                    {
                                                                        x = 16;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (Input.GetKeyDown(KeyCode.CapsLock))
                                                                        {
                                                                            x = 17;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (Input.GetKeyDown(KeyCode.RightShift) | Input.GetKeyDown(KeyCode.LeftShift))
                                                                            {
                                                                                x = 18;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (Input.GetKeyDown(KeyCode.Space))
                                                                                {
                                                                                    x = 19;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (Input.GetKeyDown(KeyCode.RightControl) | Input.GetKeyDown(KeyCode.LeftControl))
                                                                                    {
                                                                                        x = 20;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (Input.GetKeyDown(KeyCode.RightAlt) | Input.GetKeyDown(KeyCode.LeftAlt))
                                                                                        {
                                                                                            x = 21;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (Input.GetKeyDown(KeyCode.Return))
                                                                                            {
                                                                                                x = 22;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }


        if (x>0)
        {
            name = esp[x-1];           
            layer = 14;            
            generar();
        }

    }

    
}

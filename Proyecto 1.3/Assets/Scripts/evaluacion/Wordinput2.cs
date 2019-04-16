using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wordinput2 : MonoBehaviour
{

    public wordmanager2 wordmanager;

    // Update is called once per frame
    void Update()
    {

        foreach (char letra in Input.inputString)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GameManager.enter = 1;
            }
            wordmanager.Type(letra);

        }
    }
}
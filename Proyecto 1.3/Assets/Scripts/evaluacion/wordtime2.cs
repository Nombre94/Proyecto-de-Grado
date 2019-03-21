using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordtime2 : MonoBehaviour
{
    public wordmanager2 wordmanager;

    public float worddelay = 1.5f;
    public float nextwordtime = 0f;

    public void Start()
    {
        wordmanager.Addword();
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;
    public float tiempo;
    

	// Use this for initialization
	void Start ()
    {
        GameManager.tiempo = 0;
        tiempo = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameManager.tiempo == 1)
        {
            tiempo = tiempo + 1 * Time.deltaTime;
            text.text = "" + tiempo.ToString("f0");
        }
        


    }
}

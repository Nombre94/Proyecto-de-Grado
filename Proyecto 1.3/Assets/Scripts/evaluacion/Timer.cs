using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;
    public float tiempo;
    public GameObject panel;
    public Text resulA;
    public Text resulN;
    private float resul;
    public float guar;

    private static int[] caracteres = {252, 429, 224, 454, 251};

    // Use this for initialization
    void Start ()
    {
        GameManager.tiempo = 0;
        GameManager.fin = 0;
        tiempo = 0;
        guar = PlayerPrefs.GetFloat("resul", 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GameManager.tiempo == 1)
        {
            tiempo = tiempo + 1 * Time.deltaTime;
            text.text = "" + tiempo.ToString("f0");
        }

        if (GameManager.fin == 1)
        {
            resul = caracteres[GameManager.codigo] / tiempo;
            PlayerPrefs.SetFloat("resul", resul);

            panel.SetActive(true);

            resulA.text = "" + guar + "car/seg";
            resulN.text = "" + resul + "car/seg";
        }

    }
}

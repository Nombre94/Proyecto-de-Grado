using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class velocidad : MonoBehaviour {

    public Slider rapidez;
    public float reserva;

    // Use this for initialization
    void Start ()
    {
        rapidez.value = 1;
        reserva = 3;

	}
	
	// Update is called once per frame
	void Update ()
    {
        GameManager.delayobs = 3 / (rapidez.value + 0.1f);
        GameManager.velcaida = (1 * rapidez.value) + 0.1f;
        GameManager.delay = 1.5f / (rapidez.value + 0.1f);

        Debug.Log(GameManager.velocidad);
	}
}

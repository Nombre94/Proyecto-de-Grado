using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class velocidad : MonoBehaviour {

    public Slider rapidez;
    public Slider rapidez2;
    private float antr1;
    private float antr2;
    public float reserva;

    // Use this for initialization
    void Start ()
    {
        rapidez.value = 1;
        rapidez2.value = 1;
        antr1 = 1;
        antr2 = 1;
        reserva = 3;
        GameManager.delayobs = 3.5f / (GameManager.caidabase * rapidez.value);
        GameManager.velcaida = (GameManager.caidabase * rapidez.value);
        GameManager.delay = 2.5f / (GameManager.caidabase * rapidez.value);

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(antr1 != rapidez.value)
        {
            GameManager.delayobs = 3.5f / (GameManager.caidabase * rapidez.value);
            GameManager.velcaida = (GameManager.caidabase * rapidez.value);
            GameManager.delay = 2.5f / (GameManager.caidabase * rapidez.value);
            antr1 = rapidez.value;
            rapidez2.value = rapidez.value;
            antr2 = rapidez2.value;
        }
        if (antr2 != rapidez2.value)
        {
            GameManager.delayobs = 3.5f / (GameManager.caidabase * rapidez2.value);
            GameManager.velcaida = (GameManager.caidabase * rapidez2.value);
            GameManager.delay = 2.5f / (GameManager.caidabase * rapidez2.value);
            antr2 = rapidez2.value;
            rapidez.value = rapidez2.value;
            antr1 = rapidez.value;
        }

        
	}
}

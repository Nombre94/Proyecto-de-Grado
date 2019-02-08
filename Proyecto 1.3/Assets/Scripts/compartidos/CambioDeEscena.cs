using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void niveli()
    {
        GameManager.nivel = 0;
        SceneManager.LoadScene("carga");
    }

    public void nivels()
    {
        GameManager.nivel = 1;
        SceneManager.LoadScene("carga");
    }

    public void reset()
    {
        SceneManager.LoadScene("carga");
    }
    public void Menu()
    {
        
        SceneManager.LoadScene("Menu");
    }
}

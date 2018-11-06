using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioajuego : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	


    public void click()
    {
        SceneManager.LoadScene("Juego");
    }

}

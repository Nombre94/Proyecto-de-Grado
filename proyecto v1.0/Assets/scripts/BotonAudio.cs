using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonAudio : MonoBehaviour {

    public Image UIimagen;
    private int x=0; // determinarea en que imagen esta 

	// Use this for initialization
	void Start ()
    {
        UIimagen = GameObject.Find("sonido").GetComponent<Image>();
        UIimagen.sprite = Resources.Load<Sprite>("sprites/S1");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void click ()
    {
        
        if (x == 0)
        {        
            x = 1;
            UIimagen.sprite = Resources.Load<Sprite>("sprites/S2");
        }else    
        {
            x = 0;
            UIimagen.sprite = Resources.Load<Sprite>("sprites/S1");
        }

    }
}

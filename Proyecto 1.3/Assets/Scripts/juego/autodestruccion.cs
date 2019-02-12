using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  este script se encarga de la destruccion de los objetos que han salido del campo visual del usuario
public class autodestruccion : MonoBehaviour {

	// al inicializarse se invoca la clase destruir luego de un desfaz de 0.3 segundos
	void Start () {
        Invoke("destruir", 0.3f);
    }


    // en esta clase se destruye el obejto determinado 
    void destruir()
    {
        Destroy(gameObject);
    }
}

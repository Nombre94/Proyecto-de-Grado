using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// este script se encarga de todo el movimiento del personaje principal
public class Movimiento : MonoBehaviour {

    public Animator anim;
    public GameObject[] vidas;
    int contadordevidas;
    private int x = 0;  // esta variable nos determina si el usuario ya dio la señal de comienzo 

    public int vel;
    Rigidbody2D fis;
    int conf=0; // esta variable me confirma que si salto 
    public GameObject particulas; // es lo que dara el efecto de destruccion 


    public float fsalto;
    bool ensuelo = false;
    float radiosuelo = 0.2f;
    public LayerMask capasuelo;
    public Transform chesuelo;
    public Transform cheSuelDeslis;
    bool ensueloDeslis=false;


    // al inicializarse se establece la cantidad de vidas que tendra y se crea o determina el motor de fisicas
    void Start ()
    {

        contadordevidas = 2;
        fis = GetComponent<Rigidbody2D>();

    }
	
	// en esta funcion se va ejecutando un programa cada frame para ir modificando las acciones del personaje }
    //en tiempo real
	void Update () {
  
        
        ensuelo = Physics2D.OverlapCircle(chesuelo.position, radiosuelo, capasuelo);  // por medio de este codigo certifica que ya aterrizo para seguir corriendo 

        //aca se determina si el personaje esta en posicion para saltar 
        if (conf == 0)
        {
            // en esta parte se envia la orden de ejecucion de la nimacion de salto 
            anim.SetBool("salto", ensuelo);
            if (ensuelo == true)
            {
                // y se cambia la variable para evitar el posible doble salto 
                conf = 1;
            }
            
        }
       

        //esta linea de codigo se encarga de determinar si el personaje se esta deslizando o no
        ensueloDeslis= Physics2D.OverlapCircle(cheSuelDeslis.position, radiosuelo, capasuelo);

        // con este if se determina si esta de pie y en poscicion para poder deslizarse
        if (ensueloDeslis == true)
        {
            //al entrar se envia la orden de ejecucion de la animacion de deslizamiento
            anim.SetBool("deslis", false);
        }



    }


    // esta funcion es la encargada de determinar si el personaje se choco con algunos de los obstaculos
    private void OnCollisionEnter2D(Collision2D collision)
    {
            // se determina si el objeto con el que esta colisionando es efectivamente un obstaculo
            if (collision.gameObject.layer == 9 | collision.gameObject.layer == 10)
            {
                // se envia la orden para ejecutar la animacion de golpe 
                anim.SetBool("golpe", true);

               // se invoca una funcion para reestablecer el personaje a su estado normal 
                Invoke("normal", 0.3f);

               //se crea el efecto de particulas por destruccion del objeto y se procede a destruir dicho obstaculo
                Instantiate(particulas, collision.transform.position, Quaternion.identity);
                Destroy(collision.gameObject);

               //se determina si el nivel que el usuario escogio era el basico o avanzado
                if(GameManager.nivel==1)
                {
                  // se destrulle uno de los contadores de vida y se reduce la capacidad de fallos del usuario
                   Destroy(vidas[contadordevidas]);
                   contadordevidas--;
                }
                

            }
        
            // se determina si el contador de vidas ha llegado a cero
            if (contadordevidas < 0)
        {
            // se invoca la animacion de muerte del personaje y se invoca una funcion para el final de juego
            anim.SetBool("muerte", true);

            Invoke("final", 3);
        }
        
       

       

    }

    //en esta funcion se ejecutan las acciones determinadas del personaje 
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        // se determina si el usuario entro al obejeto especial que se creo en el script de cracion de obstaculos 
        if (other.gameObject.layer == 16)
        {
            // se determina la accion que debe tomar dependiendo del obstaculo que viene 
            if (GameManager.acion == 0)
            {

                if (ensuelo == true) // aqui salta y confirma que ya no este en el aire 
                {
                    fis.AddForce(Vector2.up * fsalto, ForceMode2D.Impulse);
                    anim.SetBool("salto", false);
                    ensuelo = false;
                    Invoke("pausasalto", 1);
                }
            }
            if (GameManager.acion == 1)
            {
                if (ensuelo == true) // en esta parte acata la orden de deslizarse y comprueba que este en el suelo 
                {
                    anim.SetBool("deslis", true);

                }

            }
        }
    }


    // esta funcion cancela la animacion de golpe del personaje y lo devuelve a su estado normal 
    private void normal ()
    {
        anim.SetBool("golpe", false);
    }

    // esta funcion da paso a que se active la animacion de salto nombrada antes
    void pausasalto()
    {
        conf = 0;
    }

    //en esta funcion se cancela la animacion de muerte y se da paso a la ventana de gameover 
    void final()
    {
        anim.SetBool("muerte", false);
        SceneManager.LoadScene("gameover");
    }
}

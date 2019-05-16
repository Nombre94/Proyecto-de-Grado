using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// este script se encarga de todo el movimiento del personaje principal
public class Movimiento : MonoBehaviour {

    public Animator anim;
    public GameObject[] vidas;
    int contadordevidas;
    private int x = 0;  // esta variable nos determina si el usuario ya dio la señal de comienzo 

    public int pique=3;
    public int vel;
    Rigidbody2D fis;
    int conf = 0; // esta variable me confirma que si salto 
    public GameObject particulas; // es lo que dara el efecto de destruccion 


    public float fsalto;
    bool ensuelo = false;
    float radiosuelo = 0.2f;
    public LayerMask capasuelo;
    public Transform chesuelo;
    public Transform cheSuelDeslis;
    bool ensueloDeslis = false;
    private int[] secuencia = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
    private int[] acciones;
    private int acc;
    private int realizada;
    private int contobs;
    private int vic;

    public GameObject panel;
    public Text aciertos;
    public Text errores;
    public Text perdidas;
  



    // al inicializarse se establece la cantidad de vidas que tendra y se crea o determina el motor de fisicas
    void Start()
    {
        GameManager.final = 0;
        GameManager.muerte = 0;
        GameManager.contaciertos = 0;
        GameManager.conterrores = 0;
        GameManager.contperdidas = 0;
        GameManager.random = 0;
       contadordevidas = 2;
        acciones = new int[30];
        fis = GetComponent<Rigidbody2D>();
        acc = 0;
        realizada = 0;
        contobs = 0;
        vic = 0;

    }

    // en esta funcion se va ejecutando un programa cada frame para ir modificando las acciones del personaje }
    //en tiempo real
    void Update() {

        if (vic == 1)
        {
            transform.Translate(pique * Time.deltaTime, 0, 0);
        }


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
        ensueloDeslis = Physics2D.OverlapCircle(cheSuelDeslis.position, radiosuelo, capasuelo);

        // con este if se determina si esta de pie y en poscicion para poder deslizarse
        if (ensueloDeslis == true)
        {
            //al entrar se envia la orden de ejecucion de la animacion de deslizamiento
            anim.SetBool("deslis", false);
        }


        if (GameManager.acierto == 1)
        {
            acciones[acc] = 1;
            acc = acc + 1;
            GameManager.acierto = 0;
        }
        if (GameManager.acierto == 2)
        {
            acciones[acc] = 0;
            acc = acc + 1;
            GameManager.acierto = 0;
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
            if (GameManager.nivel == 1)
            {
                // se destrulle uno de los contadores de vida y se reduce la capacidad de fallos del usuario
                Destroy(vidas[contadordevidas]);
                contadordevidas--;
            }


        }

        // se determina si el contador de vidas ha llegado a cero
        if (contadordevidas < 0)
        {
            GameManager.muerte = 1;
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
            if (acciones[realizada] == 1)
            {
                if (secuencia[contobs]== 0)
                {

                    if (ensuelo == true) // aqui salta y confirma que ya no este en el aire 
                    {
                        fis.AddForce(Vector2.up * fsalto, ForceMode2D.Impulse);
                        anim.SetBool("salto", false);
                        ensuelo = false;
                        Invoke("pausasalto", 1);
                    }

                }
                if (secuencia[contobs] == 1)
                {
                    if (ensuelo == true) // en esta parte acata la orden de deslizarse y comprueba que este en el suelo 
                    {
                        anim.SetBool("deslis", true);

                    }

                }
                contobs = contobs + 1;
                realizada = realizada + 1;
            }
            else
            {
                contobs = contobs + 1;
                realizada = realizada + 1;
            }

            

        }

        if (GameManager.final == 1)
        {
            
            Invoke("victoria", 5);
        }

    }


    // esta funcion cancela la animacion de golpe del personaje y lo devuelve a su estado normal 
    private void normal()
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

    void victoria()
    {
        GameManager.velcaida = 0;
        vic = 1;
        Invoke("mostrarpanel", 5);
    }

    void mostrarpanel()
    {
        panel.SetActive(true);
        aciertos.text = ""+ GameManager.contaciertos+" palabras";
        errores.text = "" + GameManager.conterrores + " letras";
        perdidas.text = "" + GameManager.contperdidas + " palabras";
    }
}

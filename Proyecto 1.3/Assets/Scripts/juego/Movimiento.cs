using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour {

    public Animator anim;
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


    // Use this for initialization
    void Start () {

        fis = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
  

        ensuelo = Physics2D.OverlapCircle(chesuelo.position, radiosuelo, capasuelo);  // por medio de este codigo certifica que ya aterrizo para seguir corriendo 
        if (conf == 0)
        {
            anim.SetBool("salto", ensuelo);
            if (ensuelo == true)
            {
                conf = 1;
            }
            
        }
       

        ensueloDeslis= Physics2D.OverlapCircle(cheSuelDeslis.position, radiosuelo, capasuelo);

        if (ensueloDeslis == true)
        {
            anim.SetBool("deslis", false);
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9 | collision.gameObject.layer == 10)
        {
            anim.SetBool("golpe", true);
            Invoke("normal", 0.3f);
            Instantiate(particulas, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.layer == 16)
        {
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


    private void normal ()
    {
        anim.SetBool("golpe", false);
    }

    void pausasalto()
    {
        conf = 0;
    }
}

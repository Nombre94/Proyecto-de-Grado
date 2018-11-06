using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Juego : MonoBehaviour {

    public Animator anim;
    private int x = 0;

    public int vel;
    Rigidbody2D fis;

    bool ensuelo = false;
    float radiosuelo = 0.2f;
    public LayerMask capasuelo;
    public Transform chesuelo;
    public float fsalto;

    // Use this for initialization
    void Start()
    {
        fis = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            x = 1;
            anim.SetBool("correr", true);

        }

        if (ensuelo && Input.GetAxis("Jump") > 0)
        {
            fis.AddForce(Vector2.up * fsalto, ForceMode2D.Impulse);
            anim.SetBool("suelo", false);
            ensuelo = false;

        }

        ensuelo = Physics2D.OverlapCircle(chesuelo.position, radiosuelo, capasuelo);
        anim.SetBool("suelo", ensuelo);

    }

    private void FixedUpdate()
    {
        if (x == 1)
        {
            //aqui comienza a correr 

            transform.Translate(vel * Time.deltaTime, 0, 0);

        }

    }



}

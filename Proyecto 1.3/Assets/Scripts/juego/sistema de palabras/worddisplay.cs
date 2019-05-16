using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worddisplay : MonoBehaviour
{
    public Text text;
    public float vel = 1f;

    public void setword(string word)
    {
        text.text = word;
    }

    public void removerletra()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.green;


    }

    public void removerword()
    {
        if (GameManager.limite==1)
        {
            GameManager.acierto = 2;
            GameManager.contperdidas = GameManager.contperdidas + 1;
            Destroy(gameObject);
        }
        else
        {
            GameManager.contaciertos = GameManager.contaciertos + 1;
            GameManager.acierto = 1;
            Destroy(gameObject);
        }

        
    }

    public void Update()
    {
        vel = GameManager.velcaida;
        transform.Translate(0f, -vel * Time.deltaTime, 0f);

        if (transform.position.y <= -5)
        {
            GameManager.limite = 1;
            removerword();
        }
    }

}

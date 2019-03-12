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
        Destroy(gameObject);
    }

    public void Update()
    {
        vel = GameManager.velcaida;
        transform.Translate(0f, -vel * Time.deltaTime, 0f);
    }

}

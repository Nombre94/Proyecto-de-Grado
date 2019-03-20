using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordspawn2 : MonoBehaviour
{
    public GameObject wordprefab;
    public Transform wordcanvas;

    public worddisplay2 spawword2()
    {
        Vector3 randomposition = new Vector3(Random.Range(-3.24f, 3.24f), -0.5f);

        GameObject wordobj = Instantiate(wordprefab, randomposition, Quaternion.identity, wordcanvas);
        worddisplay2 worddisplay2 = wordobj.GetComponent<worddisplay2>();

        return worddisplay2;
    }

}

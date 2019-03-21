using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordspawn2 : MonoBehaviour
{
    public GameObject wordprefab;
    public Transform wordcanvas;

    public worddisplay2 spawword2()
    {
        Vector3 randomposition = new Vector3(-0.09f, 0.07f);

        GameObject wordobj = Instantiate(wordprefab, randomposition, Quaternion.identity, wordcanvas);
        worddisplay2 worddisplay2 = wordobj.GetComponent<worddisplay2>();

        return worddisplay2;
    }

}

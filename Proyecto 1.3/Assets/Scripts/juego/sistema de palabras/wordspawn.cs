using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordspawn : MonoBehaviour
{
    public GameObject wordprefab;
    public Transform wordcanvas;

    public worddisplay spawword()
    {
        Vector3 randomposition = new Vector3(Random.Range(-3.24f, 3.24f), -0.5f);

        GameObject wordobj = Instantiate(wordprefab,randomposition,Quaternion.identity, wordcanvas);
        worddisplay worddisplay = wordobj.GetComponent<worddisplay>();

        return worddisplay;
    }

}

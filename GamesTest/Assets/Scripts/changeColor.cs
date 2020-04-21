using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    int id;
    Color[] colors = new Color[3];
    void Start()
    {
        

        

        colors[0] = Color.green;
        colors[1] = Color.yellow;
        colors[2] = Color.red;

        id = Random.Range(0, 3); 

        if (id == 0 )
        {
            this.GetComponent<Renderer>().material.color = colors[0];
            this.gameObject.tag = "target";
        }
        if (id == 1)
        {
            this.GetComponent<Renderer>().material.color = colors[1];
            this.gameObject.tag = "yellow";
        }
        if (id == 2)
        {
            this.GetComponent<Renderer>().material.color = colors[2];
            this.gameObject.tag = "red";
        }
        else
        {
            Debug.Log(id);
        }

        StartCoroutine(ColorChange());
    }

    
    void NewColor()
    {
        if (id == 0)
        {
            this.GetComponent<Renderer>().material.color = colors[1];
            this.gameObject.tag = "yellow";
            id = 1;
        }
        if (id == 1)
        {
            this.GetComponent<Renderer>().material.color = colors[1];
            this.gameObject.tag = "red";
            id = 2;
        }
        if (id == 2)
        {
            this.GetComponent<Renderer>().material.color = colors[1];
            this.gameObject.tag = "target";
            id = 0;
        }
    }

    IEnumerator ColorChange()
    {
        int t;
        if (id == 0)
        {
            t = Random.Range(5, 10);
            yield return new WaitForSeconds(t);
            NewColor();
        }
        if (id == 1)
        {
            yield return new WaitForSeconds(4);
            NewColor();
        }
        if (id == 2)
        {
            t = Random.Range(5, 10);
            yield return new WaitForSeconds(t);
            NewColor();
        }
        StartCoroutine(ColorChange());
    }
}

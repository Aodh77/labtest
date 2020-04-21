using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int id;

        Color[] colors = new Color[3];

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

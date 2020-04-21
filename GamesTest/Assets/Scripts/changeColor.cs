using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color[] colors = new Color[3];

        colors[0] = Color.green;
        colors[1] = Color.yellow;
        colors[2] = Color.red;

        this.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

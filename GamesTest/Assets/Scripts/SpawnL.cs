using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnL : MonoBehaviour
{
    
    public int LightNum = 10;
    public GameObject TrafficLight;
    
    


    void Start()
    {
        CreateCircle();
    }

    void CreateCircle()
    {
        Vector3 targetPosition = Vector3.zero;

        for (int i = 0; i < LightNum; i++)
        {
            GameObject light = Instantiate(TrafficLight);

            float angle = i * (Mathf.PI * 2 / LightNum);

            float x = Mathf.Cos(angle) * 3f;
            float Y = Mathf.Sin(angle) * 3f;

            targetPosition = new Vector3(targetPosition.x + x, targetPosition.y + Y , 0);

            light.transform.position = targetPosition;
        }
    }
}
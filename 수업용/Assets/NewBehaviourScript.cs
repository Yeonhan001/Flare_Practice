using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    public float time;
    void Update()
    {
        time = time + Time.deltaTime;
        if(time > 10 )
        {
            Debug.Log("10 seconds have passed");
            time = time - 10;
        }
    }
}

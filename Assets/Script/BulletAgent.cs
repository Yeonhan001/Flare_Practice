using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BulletAgent : MonoBehaviour
{
    public bool isActice;

    public void Activate()
    {
        gameObject.SetActive(true);
        timer = 3.0f;
        isActice = true;
    }

    public void Deactive()
    {
        isActice = false;

        gameObject.SetActive(false);
    }

    private float timer;

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.y += Time.deltaTime * 2.0f;
        transform.position = pos;

        timer -= Time.deltaTime;
        if(timer >0) return;

        Deactive();
    }

    private void OnCollistionEnter(Collision collision)
    {
        Deactive();
    }
}

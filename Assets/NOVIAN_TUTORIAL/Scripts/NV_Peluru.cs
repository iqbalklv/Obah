using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class NV_Peluru : MonoBehaviour
{
    //percobaan liat utub
    [SerializeField]  private float speed;
    [SerializeField] private float lifetime;
    [SerializeField] private GameObject destroyEffect; 

    private void Start()
    {
        Invoke("DestroyObject", lifetime);
    }
    private void Update()
    {
     transform.Translate(transform.right *speed* Time.deltaTime, 0f);
    }
    void DestroyObject()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

//percobaan menggunakan tranform ngide ngide tanpa liat utub
/*
    [SerializeField]  private float speed;
    private Transform transform;
    private Vector2 arah;

    void start()
    {
        transform = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            arah.x = 1f;
            transform.Translate(arah*speed * Time.deltaTime, 0f);
        }   
        }
}*/
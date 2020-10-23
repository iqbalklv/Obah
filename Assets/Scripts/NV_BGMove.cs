using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class NV_BGMove : MonoBehaviour
{
    public float Speed;
    Vector2 StartPos;
    public FloatVariable LevelDelay; 

    private  void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (LevelDelay.Value <= 0) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate((new Vector2(0, -1)) * Speed * Time.deltaTime);
            }
        }
        
    }
}

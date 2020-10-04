using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_System_Player : MonoBehaviour
{
    [SerializeField] private float playerSpeedP;
    [SerializeField] private float playerSpeedM;
     private SpriteRenderer warna;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //MoveUp();
            this.gameObject.GetComponent<Transform>().Translate(0f, playerSpeedP * Time.deltaTime, 0f);
            warna  = this.gameObject.GetComponent<SpriteRenderer>();
            warna.color = Color.red;    


        }
            if (Input.GetKey(KeyCode.D))
        {

            this.gameObject.GetComponent<Transform>().Translate(playerSpeedP * Time.deltaTime, 0f, 0f);
            warna = this.gameObject.GetComponent<SpriteRenderer>();
            warna.color = Color.blue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            this.gameObject.GetComponent<Transform>().Translate(0f, playerSpeedM * Time.deltaTime, 0f);
            warna = this.gameObject.GetComponent<SpriteRenderer>();
            warna.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            this.gameObject.GetComponent<Transform>().Translate(playerSpeedM * Time.deltaTime, 0f, 0f);
            warna = this.gameObject.GetComponent<SpriteRenderer>();
            warna.color = Color.black;
        }
    }

    /*private void MoveUp()
    {
        //Akses Titik Y dari Player
        Transform playerTransform = this.gameObject.GetComponent<Transform>();

        Vector2 playerPosition = playerTransform.position;

        float posisiYLama = playerPosition.y;
        //----------------------------------


        //Naikin Posisi Player Ke Atas

        float posisiYBaru = posisiYLama + (playerSpeed * Time.deltaTime);

        //-----------------------------


        //Setor posisi baru ke TRANSFORM
        playerTransform.position = new Vector2(playerTransform.position.x, posisiYBaru);
        //
    }*/
}

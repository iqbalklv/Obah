using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_System_Player : MonoBehaviour
{

    //variabel novian
    [Header("Variabel Novian")]
    [SerializeField] private float playerSpeedP;
    [SerializeField] private float playerSpeedM;
    private SpriteRenderer warna;
    //variabel novian

    /*variabel iqbal
    [Header("Variabel Iqbal")]
    [SerializeField] private float playerSpeed;
    private Transform transform;
    private SpriteRenderer sr;
    private Color warnaBaru;
    private Vector2 arah;
    */

    private void Start()
    {
        /*
        transform = this.gameObject.GetComponent<Transform>();
        sr = this.gameObject.GetComponent<SpriteRenderer>();
        warnaBaru = sr.color;
        */
    }

    void Update()
    {
        MoveNovian();
    }
    
    /*
    private void MoveIqbal()
    {
        arah.x = 0f;
        arah.y = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            arah.y = 1f;
            warnaBaru = Color.red;
        }
        if (Input.GetKey(KeyCode.D))
        {
            arah.x = 1f;
            warnaBaru = Color.blue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            arah.y = -1f;
            warnaBaru = Color.black;
        }
        if (Input.GetKey(KeyCode.A))
        {
            arah.x = -1f;
            warnaBaru = Color.yellow;
        }

        transform.Translate(arah.x * playerSpeed * Time.deltaTime, arah.y * playerSpeed * Time.deltaTime, 0f);

        sr.color = warnaBaru;
    }
    */

    private void MoveNovian()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //MoveUp();
            this.gameObject.GetComponent<Transform>().Translate(0f, playerSpeedP * Time.deltaTime, 0f);
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

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

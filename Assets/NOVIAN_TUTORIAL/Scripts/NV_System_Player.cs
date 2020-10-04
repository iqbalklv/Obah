using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_System_Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //MoveUp();
            this.gameObject.GetComponent<Transform>().Translate(0f, playerSpeed * Time.deltaTime, 0f);
        }
    }

    private void MoveUp()
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
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class System_Control : MonoBehaviour
{
    public GameEvent PlayerJump;
    public GameEvent PlayerChangeDirection;
    public IntVariable PlayerDirection;

    public FloatVariable LevelDelay;

    private void Update()
    {
        PlayerMove();     
    }
        
        public void PlayerMove()
        {
        if (LevelDelay.Value <= 0)
        {
            if (!PauseMenu.GameIsPaused )
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    PlayerJump.Raise();
                }

                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    PlayerDirection.Value = 1;
                    PlayerChangeDirection.Raise();
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    PlayerDirection.Value = -1;
                    PlayerChangeDirection.Raise();
                }
            }
        } 
        
    }
}

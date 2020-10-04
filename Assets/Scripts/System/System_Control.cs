using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_Control : MonoBehaviour
{
    public GameEvent PlayerJump;
    public GameEvent PlayerChangeDirection;
    public IntVariable PlayerDirection;

    public FloatVariable LevelDelay;

    private void Update()
    {
        if (LevelDelay.Value <= 0)
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

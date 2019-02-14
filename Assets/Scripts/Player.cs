using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Paddle
{
    private void Start()
    {
        base.direction = -1;
    }

    // Update is called once per frame
    void Update()
    {
        float inputSpeed = Input.GetAxisRaw("Vertical");        
        base.movePaddle(inputSpeed);
    }
}

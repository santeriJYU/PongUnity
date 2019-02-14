using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Paddle
{
    public Ball ball;
    public float AIPaddleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        base.direction = 1;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float ballOffset = ball.transform.position.x - transform.position.x;

        if (ballOffset < -0.5)
        {
            base.movePaddle(-1 * AIPaddleSpeed);
        }
        else if (ballOffset > 0.5)
        {
            base.movePaddle(AIPaddleSpeed);
        }
    }
}

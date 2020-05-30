using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Paddle
{
    public AILogic logic = new AILogic();

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
        base.movePaddle(logic.MoveAI(ball.transform.position.x - transform.position.x, AIPaddleSpeed));
    }
}

public class AILogic
{
    public float MoveAI(float ballOffset, float AIPaddleSpeed)
    {
        if (ballOffset < -0.5)
        {
            return -1 * AIPaddleSpeed;
        }
        else if (ballOffset > 0.5)
        {
            return AIPaddleSpeed;
        }

        return 0f;
    }
}
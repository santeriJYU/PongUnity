using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class AITet
{
    [Test]
    public void MoveAI_Test()
    {
        AILogic ai = new AILogic();

        float speed = 6.5f;
        Assert.That(ai.MoveAI(-0.7f, speed), Is.EqualTo(-speed));

        float speed2 = 3.45f;
        Assert.That(ai.MoveAI(0.6f, speed2), Is.EqualTo(speed2));

        Assert.That(ai.MoveAI(0.3f, 7.5f), Is.EqualTo(0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class ScoreTest
{
    [Test]
    public void IncreaseScore_Test()
    {
        SScore score = new SScore();

        Assert.That(score.count, Is.EqualTo(0));

        score.IncreaseScore();

        Assert.That(score.count, Is.EqualTo(1));
    }

}

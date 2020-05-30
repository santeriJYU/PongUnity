using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : Observer
{
    public SScore sscore = new SScore();

    public Text score;

    public override void OnNotify()
    {
        score.text = sscore.IncreaseScore();
    }
}


public class SScore
{
    public int count = 0;

    public string IncreaseScore()
    {
        return (++count).ToString();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : Observer
{
    public Text score;
    int count = 0;

    public override void OnNotify()
    {
        score.text = (++count).ToString();
    }
}

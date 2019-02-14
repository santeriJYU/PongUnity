using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class GameController : Observer
{
    public override void OnNotify()
    {
        newRound();
    }

    private void newRound()
    {

    }
}

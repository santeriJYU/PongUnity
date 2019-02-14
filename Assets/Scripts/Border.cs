using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class Border : MonoBehaviour
{
    public Subject subject = new Subject();

    public Score scoreCounter;
    public Ball ball;

    public Paddle player;
    public Paddle ai;

    private void Start()
    {
        subject.AddObserver(scoreCounter);
        subject.AddObserver(ball);
        subject.AddObserver(player);
        subject.AddObserver(ai);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null && collision.gameObject.CompareTag("Ball"))
        {
            subject.Notify();
        }
    }
}

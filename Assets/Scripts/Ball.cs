using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class Ball : Observer
{
    public Vector3 initialPosition;
    public Vector3 initialImpulse;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    private void ResetBall()
    {
        transform.position = initialPosition;
        rb.velocity = initialImpulse;
    }

    public override void OnNotify()
    {
        ResetBall();
    }

}

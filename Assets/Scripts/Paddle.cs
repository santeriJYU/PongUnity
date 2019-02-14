using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class Paddle : Observer
{
    private float speed = 5f;
    private double edge = 5.8f;
    private float speedUp = 1f;
    private float hitAngle = 0.5f;

    protected int direction;

    public Vector3 initialPosition;

    protected void movePaddle(float inputSpeed)
    {
        if (transform.position.x > edge && inputSpeed > 0 || transform.position.x < -edge && inputSpeed < 0)
        {
            return;
        }

        if (inputSpeed > 1)
        {
            inputSpeed = 1;
        }
        else if (inputSpeed < -1)
        {
            inputSpeed = -1;
        }

        transform.position += new Vector3(inputSpeed * speed * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null && collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(hitAngle * Mathf.Abs(rb.velocity.z) * (collision.contacts[0].point.x - transform.position.x), rb.velocity.y, rb.velocity.z + speedUp * direction);            
        }
    }

    private void ResetPaddle()
    {
        transform.position = initialPosition;
    }

    public override void OnNotify()
    {
        ResetPaddle();
    }
}

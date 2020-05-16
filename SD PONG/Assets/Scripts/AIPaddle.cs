using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public Transform ball;
    public float ballPosX;
    public Transform aiPaddle;
    public Rigidbody aiRB;
    public float moveSpeed;

    void Start()
    {
        // Verlinkung zum Ball
        ball = GameObject.Find("Ball").transform;
        aiPaddle = gameObject.transform;
        aiRB = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        ballPosX = ball.position.x;

        if (ballPosX > aiPaddle.position.x + 0.5)
        {
            // ballPosX = 1.21 / aiPaddle 1.2
            // AI Paddle nach links bewegen
            aiRB.velocity = new Vector2(moveSpeed, 0);
        }
        else if (ballPosX < aiPaddle.position.x - 0.5)
        {
            // AI Paddle nach rechts bewegen
            aiRB.velocity = new Vector2(-moveSpeed, 0);
        }
        else
            aiRB.velocity = new Vector2(0, 0);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedY;

    public bool isAutomatic = false;

    public float directionTimer = 3.0f;
    private float currentTImer = 0.0f;

    // Use this for initialization
    void Start()
    {
        currentTImer = directionTimer;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(moveSpeedX, moveSpeedY, 0) * Time.deltaTime);

        if (isAutomatic)
            SetDirectionTimer();
    }

    public void SetDirectionTimer()
    {
        currentTImer -= Time.deltaTime;

        if (currentTImer < 0)
        {
            ChangeDirection();

            currentTImer = directionTimer;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");

        ChangeDirection();
        

    }

    public void ChangeDirection()
    {
        moveSpeedX *= -1;
        moveSpeedY *= -1;
    }
}
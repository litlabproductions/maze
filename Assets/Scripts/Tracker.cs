using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{


    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

	// Use this for initialization
	void Start ()
    {
       // this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10.0f);
      // camRB = GetComponent<Rigidbody2D>();
       //camRB.velocity = new Vector2(0.0f, 1.0f);

        //speedIncTimer = 5.0f;
    }
	
	// Update is called once per frame
	void Update ()
    {
       // speedIncTimer -= Time.deltaTime;

      //  if (!playerController.IsPlayerDead())
       // {
        //    if (speedIncTimer <= 0 && speed < maxSpeed)
          //  {
            //    speed += .4f;
            //    speedIncTimer = 3.0f;
           // }

           // camRB.velocity = new Vector2(0.0f, speed);
        //}
        //else
         //   camRB.velocity = new Vector2(0.0f, 0.0f);
        //
	}
}

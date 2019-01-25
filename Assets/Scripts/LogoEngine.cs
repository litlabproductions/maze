using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoEngine : MonoBehaviour
{
    private Rigidbody2D engineRB;

    public float speed;

    // Use this for initialization
    void Start ()
    {
        engineRB = GetComponent<Rigidbody2D>();

        engineRB.velocity = new Vector2(0.0f, speed);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed = -speed;
        engineRB.velocity = new Vector2(0.0f, speed);
    }

}

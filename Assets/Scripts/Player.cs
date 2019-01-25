using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool enable = false;
    public int playerDirection;
    private Vector2 rotTarget;
    private Vector2 direction;
    private float angle;
    private Quaternion rotation;

    public float rotationSpeed;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        //playerDirection ;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (enable == true)
        {
            rotTarget = transform.position;

            if (Input.touchCount > 0)
                rotTarget = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            switch (playerDirection)
            {
                case 0:
                    rotTarget.y += 3;
                    direction = rotTarget - (Vector2)this.transform.position;
                    angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                    rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

                    this.transform.Translate(Vector2.up * speed * Time.deltaTime);
                    break;

                case 1:
                    rotTarget.y += 3;
                    direction = rotTarget - (Vector2)this.transform.position;
                    angle = Mathf.Atan2(direction.y, -direction.x) * Mathf.Rad2Deg - 90;
                    rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

                    this.transform.Translate(Vector2.up * -speed * Time.deltaTime);
                    break;
            }
        }
        else
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                Begin();
	}

    private void Begin()
    {
        enable = true;
        
    }
}

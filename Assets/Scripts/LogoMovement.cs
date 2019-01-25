using UnityEngine;
using System.Collections;

public class LogoMovement : MonoBehaviour
{
    public Vector2 destination;
    public float speed = 0.1f;

    private float timer = 0.5f;

    private Vector2 topLocation;
    private Vector2 bottomLocation;

    public Transform topMarker;

    public Transform botMarker;

    private bool moveUp;

    void Start()
    {
      //  topLocation = new Vector2(topMarker);
     //   bottomLocation = new Vector2(transform.position.x, transform.position.y - 10.0f);

    //    destination = topLocation;
        moveUp = true;

        //destination.y -= 20.0f;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0.0f)
            MoveLogo();

        //transform.position = Vector2.Lerp(transform.position, destination, speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
       // destination.y *= -1.0f;
    }
    
    public void MoveLogo()
    {
        moveUp = !moveUp;

        if (moveUp)
        {
            destination = new Vector2(topMarker.position.x, topMarker.position.y);
            transform.position = Vector2.Lerp(transform.position, destination, speed * Time.deltaTime);
        }
        else
        {
            destination = new Vector2(botMarker.position.x, botMarker.position.y);
            transform.position = Vector2.Lerp(transform.position, destination, speed * Time.deltaTime);
        }
    }
}
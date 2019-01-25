using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public bool rotateLeft;
    public float rotationSpeed;
	
	void Update ()
    {
        if (rotateLeft)
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);   // ~ Rotates + degrees per second around z axis.
        else
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);   // ~ Rotates - degrees per second around z axis.
    }
}
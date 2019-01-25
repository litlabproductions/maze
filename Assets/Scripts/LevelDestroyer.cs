using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDestroyer : MonoBehaviour
{
    public GameObject destructionPoint;

	void Start ()
    {
        destructionPoint = GameObject.Find("DestructionPoint");
	}
	
	void Update ()
    {
        if (transform.position.y < destructionPoint.transform.position.y)
            Destroy(gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject[] theMazePieces;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformHeight;

    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        platformHeight = 9.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if (transform.position.y < generationPoint.position.y && player.activeSelf)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + platformHeight + distanceBetween, transform.position.z);

            Instantiate(theMazePieces[Random.Range(0, theMazePieces.Length)], transform.position, transform.rotation);
        }
	}
}

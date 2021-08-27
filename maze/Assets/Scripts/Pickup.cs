using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //private ParticleSystem currentParticles;

    // Use this for initialization
    void Start ()
    {
        //currentParticles = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

}

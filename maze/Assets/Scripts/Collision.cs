using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollision2dEnter(Collision col)
    {
        Debug.Log("GOT EM");


        //if (col.gameObject.name == "prop_powerCube")
        //{
        //    Destroy(col.gameObject);
        //}
    }
}

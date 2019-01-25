using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRender : MonoBehaviour {

    public TrailRenderer trail;
    // Use this for initialization
    void Start()
    {
        trail.sortingLayerName = "5";
        trail.sortingOrder = 0;
     

    }
}

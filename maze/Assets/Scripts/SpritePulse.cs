using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePulse : MonoBehaviour
{
    public Color A = Color.magenta;
    public Color B = Color.blue;
    public float speed = 1.0f;

    SpriteRenderer spriteRenderer;

    void Start()    
    {
        speed = Random.Range(0.0f, 1.2f);


        B.a = Random.Range(0.35f, 1.0f); 
        B.b = Random.Range(0.1f, 1.0f);
        B.g = Random.Range(0.1f, 1.0f);
        B.r = Random.Range(0.1f, 1.0f);

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        spriteRenderer.color = Color.Lerp(A, B, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}

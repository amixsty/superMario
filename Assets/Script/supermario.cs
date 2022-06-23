using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SuperMario : MonoBehaviour
{
    private Rigidbody2D mario;
    public float speed = 3;
    public float jump = 6;
    public int scores;
    public GameObject bitcoin;
    void Start()
    {
        mario = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float sp = Input.GetAxisRaw("Horizontal");
        mario.velocity = new Vector2(sp*speed,mario.velocity.y);
        if(Input.GetKeyDown(KeyCode.UpArrow))
            mario.velocity += Vector2.up*jump;
    }
    void  OnCollisionEnter2D(Collision2D bitcoin)
    {
        if (bitcoin.gameObject.name.StartsWith("bitcoin"))
        {
            Destroy (bitcoin.gameObject);
            scores +=1;
            Debug.Log(scores);
        }
    }
}
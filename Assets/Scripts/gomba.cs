using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemy : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
    void OnCollisionEnter2D(Collision2D header)
    {
        if(header.gameObject.name.StartsWith("supermario"))
        { 
            Destroy(header.gameObject);
            Debug.Log("You lose it !");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flag : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D mario)
    {
        SceneManager.LoadScene("scene2");
    }
}

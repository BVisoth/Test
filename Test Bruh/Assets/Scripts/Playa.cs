using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playa : MonoBehaviour
{
    public float speed = 5.0f;
    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * speed;

    }
}

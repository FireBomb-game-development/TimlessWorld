using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float amplitude;  // The maximum angle the pendulum can swing
    public float frequency;  // The speed of the pendulum swing

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float angle = amplitude * Mathf.Sin(frequency * Time.time);
        rb2d.rotation = angle;
    }
}
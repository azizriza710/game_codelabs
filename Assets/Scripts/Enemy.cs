using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = -4f;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(speed, 0);
    }

    private void Update()
    {
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }
}

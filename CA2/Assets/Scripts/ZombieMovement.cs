using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject player;

    public float movementSpeed = 100;
    public float trackingRange = 5;

    float h, v;
    Rigidbody2D body;

    void Start()
    {
        //player = gameObject.CompareTag("Player");
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();

        transform.up = direction;

        if(Vector3.Distance(transform.position, player.transform.position) <= trackingRange)
        {
            body.velocity = transform.up * new Vector2(h, v) * movementSpeed * Time.deltaTime;
        }
    }
}

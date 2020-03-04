﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 2;
    public int Damage = 10;

    private void Start()
    {
        Invoke("DestroyBullet", 2);
    }

    //sets the velocity of the bullet
    public void SetDirection(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }

    //can be extended by later (virtual)
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        ApplyDamageToHealth(collision.gameObject);
        DestroyBullet();
    }

    //can be extended by later (virtual)
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        ApplyDamageToHealth(collision.gameObject);
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void ApplyDamageToHealth(GameObject collidedObject)
    {
        HealthComponent health = collidedObject.GetComponent<HealthComponent>();

        if (health != null)
            health.ApplyDamage(Damage);
    }
    
}

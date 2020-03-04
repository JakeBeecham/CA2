using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : HealthComponent
{
    public GameManager manager;

    public GameObject splatterPrefab;

    private void Start()
    { 

    }

    public override void KillCharacter()
    {
        manager.RecordZombieDeath();

        Instantiate(splatterPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);

        base.KillCharacter();
    }
}

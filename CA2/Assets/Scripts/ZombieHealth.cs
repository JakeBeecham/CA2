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
        
        base.KillCharacter();
    }
}

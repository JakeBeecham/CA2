using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int startingZombieCount = 10;
    public int zombieCount;

    void Awake()
    {
        zombieCount = startingZombieCount;
        //do not remove
        DontDestroyOnLoad(this);
    }

    private void Update()
    {

    }

    void RecordZombieDeath()
    {
        zombieCount--;

        if(zombieCount <= 0)
        {
            SceneManager.LoadScene("GameComplete");
        }
    }
}

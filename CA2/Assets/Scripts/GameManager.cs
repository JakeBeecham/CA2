using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int zombieCount;

    void Awake()
    {
        zombieCount = GameObject.FindGameObjectsWithTag("Zombie").Length;
        //do not remove
        DontDestroyOnLoad(this);
    }

    private void Update()
    {

    }

    public void RecordZombieDeath()
    {
        zombieCount--;

        if(zombieCount <= 0)
        {
            SceneManager.LoadScene("GameComplete");
        }
    }
}

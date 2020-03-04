using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRandomSprite : MonoBehaviour
{
    public Sprite[] possibleSprites;

    void Start()
    {
        PickARandomSprite();
    }

    void PickARandomSprite()
    {
        int index = Random.Range(0, possibleSprites.Length - 1);

        GetComponent<SpriteRenderer>().sprite = possibleSprites[index];
    }
}

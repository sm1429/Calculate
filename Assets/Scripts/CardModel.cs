using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite[] faces;
    public Sprite cardBack;

    public int cardIndex;   // e.g. faces[cardIndex];

    public void ToglleFace(bool showFace)
    {
        if (showFace)
        {
            spriteRenderer.sprite = faces[cardIndex];
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}

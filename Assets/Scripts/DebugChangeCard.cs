using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    private CardModel cardModel;
    private int cardIndex = 0;

    public GameObject card;

    private void Awake()
    {
        cardModel = card.GetComponent<CardModel>();
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))
        {
            if (cardIndex >= cardModel.faces.Length)
            {
                cardIndex = 0;
                cardModel.ToglleFace(false);
            }
            else
            {
                cardModel.cardIndex = cardIndex;
                cardModel.ToglleFace(true);
                cardIndex++;
            }
        }
    }
}

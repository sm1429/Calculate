using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckView : MonoBehaviour
{
    Deck deck;

    public Vector3 startPosition;
    public float cardOffset;
    public GameObject cardPrefab;

    private void Start()
    {
        deck = GetComponent<Deck>();
        ShowCards();
    }

    public void ShowCards()
    {
        int cardCount = 0;

        foreach (int i in deck.GetCards())
        {
            float co = cardOffset * cardCount;

            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
            Vector3 tempPosition = startPosition + new Vector3(co, 0f);
            cardCopy.transform.position = tempPosition;

            CardModel cardModel = cardCopy.GetComponent<CardModel>();
            cardModel.cardIndex = i;
            cardModel.ToglleFace(true);

            cardCount++;
        }
    }
}

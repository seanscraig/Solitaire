using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    private Solitaire solitaire;

    // Need a reference to interact with the Solitaire GM
    void Start()
    {
        solitaire = FindObjectOfType<Solitaire>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }

    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                // what has been hit? Deck/Card/EmptySlot
                if (hit.collider.CompareTag("Deck"))
                {
                    // clicked deck
                    Deck();
                }
                else if (hit.collider.CompareTag("Card"))
                {
                    // clicked card
                    Card();
                }
                else if (hit.collider.CompareTag("Top"))
                {
                    // clicked top
                    Top();
                }
                else if (hit.collider.CompareTag("Bottom"))
                {
                    // clicked bottom
                    Bottom();
                }
            }
        }
    }

    void Deck()
    {
        // deck click actions
        print("Deck Clicked!");
        solitaire.DealFromDeck();
    }

    void Card()
    {
        // card click actions
        print("Card Clicked!");
    }

    void Top()
    {
        // top click actions
        print("Top Clicked!");
    }

    void Bottom()
    {
        // bottom click actions
        print("Bottom Clicked!");
    }
}
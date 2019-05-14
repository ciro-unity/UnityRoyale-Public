using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityRoyale
{
    [CreateAssetMenu(fileName = "NewDeck", menuName = "Unity Royale/Deck Data")]
    public class DeckData : ScriptableObject
    {
        public AssetLabelReference[] labelsToInclude; //set by designers

        private CardData[] cards; //the deck of actual cards, needs to be shuffled
        private int currentCard = 0;

        public void CardsRetrieved(List<CardData> cardDataDownloaded)
        {
            //load the actual cards data into an array, ready to use
            int totalCards = cardDataDownloaded.Count;
            cards = new CardData[totalCards];
            for(int c=0; c<totalCards; c++)
            {
                cards[c] = cardDataDownloaded[c];
            }
        }

        public void ShuffleCards()
        {
            //TODO: shuffle cards
        }

		//returns the next card in the deck. You probably want to shuffle cards first
		public CardData GetNextCardFromDeck()
        {
            //advance the index
            currentCard++;
            if(currentCard >= cards.Length)
                currentCard = 0;

            return cards[currentCard];
        }
    }
}

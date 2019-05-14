using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityRoyale
{
    public class CPUOpponent : MonoBehaviour
    {
        public DeckData aiDeck;
        public UnityAction<CardData, Vector3, Placeable.Faction> OnCardUsed;

        private bool act = false;
        private Coroutine actingCoroutine;

		public float opponentLoopTime = 5f;

        public void LoadDeck()
        {
            DeckLoader newDeckLoaderComp = gameObject.AddComponent<DeckLoader>();
            newDeckLoaderComp.OnDeckLoaded += DeckLoaded;
            newDeckLoaderComp.LoadDeck(aiDeck);
        }

        //...

		private void DeckLoaded()
		{
			Debug.Log("AI deck loaded");

			//StartActing();
        }

		public void StartActing()
		{
			Invoke("Bridge", 0f);
		}

        private void Bridge()
        {
            act = true;
            actingCoroutine = StartCoroutine(CreateRandomCards());
        }

        public void StopActing()
        {
            act = false;
            StopCoroutine(actingCoroutine);
        }

        //TODO: create a proper AI
		private IEnumerator CreateRandomCards()
		{
            while(act)
            {
			    yield return new WaitForSeconds(opponentLoopTime);


                if(OnCardUsed != null)
				{
					Vector3 newPos = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(3f, 8.5f));
                    OnCardUsed(aiDeck.GetNextCardFromDeck(), newPos, Placeable.Faction.Opponent);
				}
            }
		}
	}
}
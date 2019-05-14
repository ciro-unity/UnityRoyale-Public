using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityRoyale
{
    public class Card : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
    {
        public UnityAction<int, Vector2> OnDragAction;
        public UnityAction<int> OnTapDownAction, OnTapReleaseAction;

        [HideInInspector] public int cardId;
        [HideInInspector] public CardData cardData;

        public Image portraitImage; //Inspector-set reference
        private CanvasGroup canvasGroup;

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        //called by CardManager, it feeds CardData so this card can display the placeable's portrait
        public void InitialiseWithData(CardData cData)
        {
            cardData = cData;
            portraitImage.sprite = cardData.cardImage;
        }

        public void OnPointerDown(PointerEventData pointerEvent)
        {
            if(OnTapDownAction != null)
                OnTapDownAction(cardId);
        }

        public void OnDrag(PointerEventData pointerEvent)
        {
            if(OnDragAction != null)
                OnDragAction(cardId, pointerEvent.delta);
        }

        public void OnPointerUp(PointerEventData pointerEvent)
        {
            if(OnTapReleaseAction != null)
                OnTapReleaseAction(cardId);
        }

        public void ChangeActiveState(bool isActive)
        {
            canvasGroup.alpha = (isActive) ? .05f : 1f;
        }
    }
}
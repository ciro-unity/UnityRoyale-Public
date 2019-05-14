using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

namespace UnityRoyale
{
	public class CardPlayerBridge : MonoBehaviour, INotificationReceiver
	{
		public GameManager gameManager; //public reference

		//will ask the manager to play a Card
		public void OnNotify(Playable origin, INotification notification, object context)
		{
			CardMarker cm = notification as CardMarker;
			
			//cm might be null because this notification receiver actually gets notifications from ALL markers on the Timeline
			//so we need to make sure it's of type CardMarker
			if(cm != null)
				gameManager.UseCard(cm.card, cm.position, cm.faction);
		}
	}
}
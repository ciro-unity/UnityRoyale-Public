using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using System;
using UnityEngine.Timeline;
using UnityEngine.Playables;

namespace UnityRoyale
{
	[Serializable, DisplayName("Card Marker")]
	public class CardMarker : Marker, INotification
	{
		public CardData card;
		public Vector3 position;
		public Placeable.Faction faction;

		//required by INotification but we're not actually using it
		public PropertyName id { get { return new PropertyName(); } }
	}
}

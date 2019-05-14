using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityRoyale
{
	public class Projectile : MonoBehaviour
	{
		[HideInInspector] public ThinkingPlaceable target;
		[HideInInspector] public float damage;
		private float speed = 3f;
		private float progress = 0f;
		private Vector3 offset = new Vector3(0f, 1.2f, 0f);
		private Vector3 initialPosition;

		private void Awake()
		{
			initialPosition = transform.position;
		}

		public float Move()
		{
			progress += Time.deltaTime * speed;
			transform.position = Vector3.Lerp(initialPosition, target.transform.position + offset, progress);

			return progress;
		}
	}
}
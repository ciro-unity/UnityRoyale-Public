using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityRoyale
{
    //A static, non-moving obstacle that disappears on its own after a while
    public class Obstacle : Placeable
    {
        [HideInInspector] public float timeToRemoval;
		
		private AudioSource audioSource;

        private void Awake()
        {
            pType = Placeable.PlaceableType.Obstacle;
            faction = Placeable.Faction.None; //faction is always none for Obstacles
			audioSource = GetComponent<AudioSource>();
        }

        public void Activate(PlaceableData pData)
        {
            timeToRemoval = pData.lifeTime;
			dieAudioClip = pData.dieClip;
            //TODO: add more as necessary

            StartCoroutine(Die());
        }

        private IEnumerator Die()
        {
			yield return new WaitForSeconds(timeToRemoval);
            
			//audioSource.PlayOneShot(dieAudioClip, 1f);

            if(OnDie != null)
                OnDie(this);

            Destroy(this.gameObject);
        }
    }
}

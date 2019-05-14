using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityRoyale
{
	public class UIManager : MonoBehaviour
	{
        public GameObject healthBarPrefab;
		public GameObject gameOverUI;

		private List<HealthBar> healthBars;
        private Transform healthBarContainer;

		private void Awake()
		{
			healthBars = new List<HealthBar>();
            healthBarContainer = new GameObject("HealthBarContainer").transform;
		}

		public void AddHealthUI(ThinkingPlaceable p)
        {
            GameObject newUIObject = Instantiate<GameObject>(healthBarPrefab, p.transform.position, Quaternion.identity, healthBarContainer);
            p.healthBar = newUIObject.GetComponent<HealthBar>(); //store the reference in the ThinkingPlaceable itself
            p.healthBar.Initialise(p);
			
			healthBars.Add(p.healthBar);
        }

		public void RemoveHealthUI(ThinkingPlaceable p)
		{
			healthBars.Remove(p.healthBar);
			
			Destroy(p.healthBar.gameObject);
		}

		public void ShowGameOverUI()
		{
			gameOverUI.SetActive(true);
		}

		public void OnRetryButton()
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
		}

		private void LateUpdate()
		{
			for(int i=0; i<healthBars.Count; i++)
			{
				healthBars[i].Move();
			}
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	public AudioMixer audioMixer;
	public AudioMixerSnapshot gameplaySnapshot, endMatchSnapshot;
	public AudioClip appearSFX;

	private AudioSource audioSource;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void GoToDefaultSnapshot()
	{
		ChangeSnapshots(1f, 0f, .1f);
	}

	public void GoToEndMatchSnapshot()
	{
		ChangeSnapshots(0f, 1f, 1f);
	}

	private void ChangeSnapshots(float gameplayWeight, float endMatchWeight, float time)
	{	
		//AudioMixerSnapshot[] snaps = new AudioMixerSnapshot[]{gameplaySnapshot, endMatchSnapshot};
		//float[] weights = new float[]{gameplayWeight, endMatchWeight};
		//audioMixer.TransitionToSnapshots(snaps, weights, time);
	}

	public void PlayAppearSFX(Vector3 location)
	{
		//PlayOneShotSFX(location, appearSFX);
	}

    private void PlayOneShotSFX(Vector3 location, AudioClip clip)
    {
		transform.position = location;
        //audioSource.PlayOneShot(clip, 1f);
    }
}

using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicArray;

	private AudioSource audioSrc;

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}
	
	void Start () {
		audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnLevelWasLoaded (int level)
	
	{
		AudioClip levelMusic = levelMusicArray[level];
		
		if(levelMusic)
		{
			audioSrc.clip = levelMusic;
			audioSrc.loop = true;
			audioSrc.Play();
		}
	}
	
	public void SetVolume(float volume)
	{
		audioSrc.volume = volume;
	}
	
}

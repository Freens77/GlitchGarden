using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

	private MusicManager musicMgr;


	// Use this for initialization
	void Start () {
	musicMgr = FindObjectOfType<MusicManager>();

	if(musicMgr) {
		float volume = PlayerPreferences.GetMasterVolume();
		musicMgr.SetVolume(volume);
		}	else {
			Debug.LogWarning("no music manager found - cannot set volume");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
}

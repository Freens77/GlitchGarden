using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	
	private LevelManager levelMgr;
	private MusicManager musicMgr;


	// Use this for initialization
	void Start () {
	levelMgr = GameObject.FindObjectOfType<LevelManager>();
	musicMgr = GameObject.FindObjectOfType<MusicManager>();
	
	volumeSlider.value = PlayerPreferences.GetMasterVolume();
	difficultySlider.value = PlayerPreferences.GetDifficulty();
	
	}
	
	// Update is called once per frame
	void Update () {
		musicMgr.SetVolume(volumeSlider.value);
	}
	
	
	
	//SAVE PERSISTENT VALUES ON EXIT
	public void SaveAndExit()
	{
		PlayerPreferences.SetMasterVolume(volumeSlider.value);
		PlayerPreferences.SetDifficulty(difficultySlider.value);
		levelMgr.LoadLevel("01a_MainMenu");
	}
	
	public void SetDefaults()
	{
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2;
	}
	
}

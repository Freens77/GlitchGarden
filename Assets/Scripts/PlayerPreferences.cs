using UnityEngine;
using System.Collections;

public class PlayerPreferences : MonoBehaviour {

	public const string VOLUME_KEY = "master_volume";
	public const string DIFFICULTY_KEY = "difficulty";
	public const string LEVEL_KEY = "level_unlocked_";
	

	// MASTER VOLUME GETTER/SETTER
	
	public static void SetMasterVolume(float volume)
	{
		if(volume > 0f && volume < 1f)
		{
			PlayerPrefs.SetFloat(VOLUME_KEY, volume);
		} else {
			Debug.LogError("Master Volume out of range");
		}
	}
	
	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(VOLUME_KEY);
	}
	
	// LEVEL UNLOCK GETTER/SETTER
	
	public static void UnlockLevel(int level)
	{
		if(level <= Application.levelCount - 1)
		{
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); //use 1 for true
		} else {
			Debug.LogError("FAILED - attempting to load level not in build");	
		}
	}
	
	
	public static bool IsLevelUnlocked(int level)
	{
		int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
		bool isLevelUnlocked = (levelValue == 1);
		
		if(level <= Application.levelCount - 1)
		{
			return isLevelUnlocked;
		} else {
			Debug.LogError("FAILED - querying level that is not in build");
			return false;
		}
		
	}
	
	// DIFFICULTY LEVEL GETTER/SETTER
	
	public static void SetDifficulty(float difficulty)
	{
		if(difficulty >= 1f && difficulty <= 3f)
		{
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("FAILED - attempting to set difficulty outside of range");
		}
	}
	
	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	
	
}

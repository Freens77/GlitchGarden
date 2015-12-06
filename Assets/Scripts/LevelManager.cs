using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public float autoLoadNextLevelAfter;

	public void Start()
	{
		if(Application.loadedLevel == 0)
		{
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		} 
		
	}
	

	public void LoadLevel(string levelName) 
	{
		Application.LoadLevel(levelName);
	}
	
	
	public void QuitGame() 
	{
		Application.Quit();
	}
	
	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	
	}
	
}

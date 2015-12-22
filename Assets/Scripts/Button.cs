using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject defenderPrefab;

	private Button[] buttonArrary;
	
	private static GameObject selectedDefender;

	void Start () {
		buttonArrary = GameObject.FindObjectsOfType<Button>();
	}
	
	void Update () {
	
	}
	

	void OnMouseDown () {
			
		foreach(Button button in buttonArrary)
		{
			button.GetComponent<SpriteRenderer>().color = Color.black;
		}
	
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPrefab;
	}
}

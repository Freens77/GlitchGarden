using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;
	public GameObject parentObject;
	
	
	void Start () {
		parentObject = GameObject.Find("Defenders");
		
		if(!parentObject)
		{
			parentObject = new GameObject("Defenders");
		}
	}
	

	void Update () {
	
	}



	void OnMouseDown() {
		GameObject defender = Button.selectedDefender;
		Vector2 snapGridPos = GetWorldCoordinatesOnMouseDown();
		Quaternion rotation = Quaternion.identity;
		
		GameObject newDefender = (GameObject) Instantiate(defender, snapGridPos, rotation);
		newDefender.transform.parent = parentObject.transform;
		
	}	
	
	Vector2 GetWorldCoordinatesOnMouseDown() {
		float distanceFromCamera = 10f;  //arbitrary value required for the use of Vector3
		Vector3 mouseClickPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceFromCamera);
		Vector2 worldPos = myCamera.ScreenToWorldPoint(mouseClickPos);
	
		Debug.Log("worldCoords: " + mouseClickPos);
	
		return GetGridCentreWorldPosition(worldPos);
	}
	
	Vector2 GetGridCentreWorldPosition(Vector2 rawWorldPos) {
		
		float x = Mathf.Round(rawWorldPos.x);
		float y = Mathf.Round(rawWorldPos.y);
		
		return new Vector2(x,y);		
	}
	
	
}

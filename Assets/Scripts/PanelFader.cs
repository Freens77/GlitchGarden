using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelFader : MonoBehaviour {


	private float fadeInTime = 1.5f;
	private Image fadePanel;
	private Color currentColor = Color.black;	
	
	void Start () {
		fadePanel = GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Time.timeSinceLevelLoad < fadeInTime)
		{
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChange; 
			fadePanel.color = currentColor;
		
			
		} else {
			gameObject.SetActive(false);
		}
		
	}
}

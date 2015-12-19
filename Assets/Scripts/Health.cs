using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	//CLASS PROPERTIES
	public float health = 50f;
	

	// START / UPDATE METHODS
	void Start () {
	
	}
	void Update () {
	
	}
	
	
	//CLASS METHODS	
	public void TakeDamage(float damage)
	{
		this.health -= damage;
		
		if(this.health <= 0)
		{
			DestroyObject();
		}
	}
	
	
	public void DestroyObject()
	{
		Destroy(gameObject);
	}
	
	public void TakeHealing(float healing)
	{
		this.health += healing;		
	}
	
	
}

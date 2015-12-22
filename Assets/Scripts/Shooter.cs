using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject gun;

	private GameObject parentObject;


	void Start () {
		parentObject = GameObject.Find("Projectiles");
		
		
		if(!parentObject)
		{
			parentObject = new GameObject("Projectiles");
		}
	}
	
	void ShootProjectile() {
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.parent = parentObject.transform;
		newProjectile.transform.position = gun.transform.position;
		
	}
	
	
	
	
}

using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject parentObject;
	public GameObject gun;

	
	void ShootProjectile() {
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.parent = parentObject.transform;
		newProjectile.transform.position = gun.transform.position;
		
	}
	
	
	
	
}

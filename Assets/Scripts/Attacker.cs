using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	//CLASS PROPERTIES
	
	[Range (-1f, 1.5f)]
	public float currentSpeed;
	
	private GameObject currentTarget;
	private Animator animator;

	// START / UPDATE METHODS
	void Start () {
	}
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
		
		animator = gameObject.GetComponent<Animator>();
		if(!currentTarget)
		{
			animator.SetBool("IsAttacking", false);
		}
	}
	
	// CLASS METHODS
	
	public void SetCurrentSpeed(float speed)
	{
		this.currentSpeed = speed;
	}
	
	public void StrikeCurrentTarget(float damage)
	{
		if(currentTarget) {
			Health health = currentTarget.GetComponent<Health>();
			
			if(health) {
				health.TakeDamage(damage);
			}
		}
		
	}
	
	
	public void Attack(GameObject gameObj)
	{
		this.currentTarget = gameObj;
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log(name + " trigger event");
	}
	
}

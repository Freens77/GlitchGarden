using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Fox : MonoBehaviour {

	private Animator animator;
	private Attacker attacker;

	void Start () {
		animator = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	void Update () {
	
	}

	
	void OnTriggerEnter2D(Collider2D collider)
	{
		GameObject colliderGameObj = collider.gameObject;
		
		//EXIT method if it's not a Defender object
		if(!colliderGameObj.GetComponent<Defender>())
		{
			return;
		}
		
		if(colliderGameObj.GetComponent<Stone>())
		{
			animator.SetTrigger("Fox Jumping"); //set the trigger to "Fox Jumping" if it's a Stone obj
		}
		else{
			animator.SetBool("IsAttacking", true);
			attacker.Attack(colliderGameObj);
		}
		
	}	
	
	
	
}

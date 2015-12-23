using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject[] attackerPrefabs;


	
	void Update () {
		foreach(GameObject attacker in attackerPrefabs)
		{
			if(IsTimeToSpawn(attacker))
			{
				Spawn(attacker);
			}
		}
	}
	
	
	
	void Spawn(GameObject attacker) {
		GameObject theAttacker = (GameObject)Instantiate(attacker);
		theAttacker.transform.parent = transform;
		theAttacker.transform.position =  transform.position;
		
	}
	
	bool IsTimeToSpawn(GameObject attacker) {
		Attacker theAttacker = attacker.GetComponent<Attacker>();		
		float meanSpawnDelay = theAttacker.TimeBetweenAppearances * 5; //5 is the number of lanes	
		float spawnsPerSecond = 1 / meanSpawnDelay;		
		float thresholdTime = spawnsPerSecond * Time.deltaTime;
			
		if(Random.value < thresholdTime) {
			return true;
		} else {
			return false;
		}
		
	}
	
}

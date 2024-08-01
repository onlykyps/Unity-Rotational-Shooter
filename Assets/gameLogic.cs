using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLogic : MonoBehaviour {

	public GameObject enemyToSpawn;
	public float enemySpawnTimeFLOAT0 = 5.7f;
	public float enemySpawnTimeFLOAT1 = 2.5f;
	public float enemySpawnTimeFLOAT2 = 10.2f;
	public float enemySpawnTimeFLOAT3 = 7.5f;
	public bool canSpawn = true;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (enemySpawnTimer0());
		StartCoroutine (enemySpawnTimer1());
		StartCoroutine (enemySpawnTimer2());
		StartCoroutine (enemySpawnTimer3());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator enemySpawnTimer0()
	{
		while (canSpawn == true) 
		{
			spawnEnemy0 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT0);
		}

	}


	IEnumerator enemySpawnTimer1()
	{
		while (canSpawn == true) 
		{
			spawnEnemy1 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT1);
		}

	}

	IEnumerator enemySpawnTimer2()
	{
		while (canSpawn == true) 
		{
			spawnEnemy2 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT2);
		}

	}

	IEnumerator enemySpawnTimer3()
	{
		while (canSpawn == true) 
		{
			spawnEnemy3 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT3);
		}

	}

	void spawnEnemy0 ()
	{
		Instantiate (enemyToSpawn,new Vector3(-38,17,0), Quaternion.identity);
	}

	void spawnEnemy1 ()
	{
		Instantiate (enemyToSpawn,new Vector3(36,18,0), Quaternion.identity);
	}

	void spawnEnemy2 ()
	{
		Instantiate (enemyToSpawn,new Vector3(38,-17,0), Quaternion.identity);
	}

	void spawnEnemy3 ()
	{
		Instantiate (enemyToSpawn,new Vector3(-38,-17,0), Quaternion.identity);
	}
}

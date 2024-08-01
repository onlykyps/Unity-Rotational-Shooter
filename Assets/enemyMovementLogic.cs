using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementLogic : MonoBehaviour {
	public float enemySpeed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveEnemyToPlayer ();
		
	}

	void moveEnemyToPlayer()
	{
		transform.position = Vector3.Slerp (transform.position, new Vector3(0,0,0),enemySpeed*Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D transformCollision)
	{
		if (transformCollision.gameObject.tag == "Projectile") 
		{
			Destroy (transformCollision.gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyProjectile : MonoBehaviour {
	scoreLogic addToScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D transformCollision)
	{
		if (transformCollision.gameObject.tag == "Enemy") 
		{
			callScoreLogicScript ();
			Destroy (transformCollision.gameObject);
		}
	}

	void callScoreLogicScript()
	{
		addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<scoreLogic> ();
		addToScore.addToScoreVOID ();
	}
}

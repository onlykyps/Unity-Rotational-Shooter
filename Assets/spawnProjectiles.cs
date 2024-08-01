using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProjectiles : MonoBehaviour {
	public GameObject projectile;
	public Vector2 mousePosition;
	public Vector3 localOffSet = new Vector3 (0, 0, 0);
	// Use this for initialization
	void Start () {
		transform.gameObject.layer = 5;
	}
	
	// Update is called once per frame
	void Update () 
	{
		getMouseClickDown ();
	}

	void getMouseClickDown()
	{
		if (Input.GetMouseButtonDown (button: 0)) 
		{
			spawnObjectProjectileVOID ();
		}
	}

	void spawnObjectProjectileVOID()
	{
		GameObject projectileClone;
		Vector2 mousPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		projectileClone = Instantiate (projectile,transform.TransformPoint(Vector3.left + localOffSet),Quaternion.Euler(0,0,transform.eulerAngles.z))as GameObject;
		Rigidbody2D projectileRigidBody = projectileClone.AddComponent<Rigidbody2D> ();
		projectileRigidBody.velocity = mousPos * 4.0f;
		projectileRigidBody.gravityScale = 0.0f;

	}

}

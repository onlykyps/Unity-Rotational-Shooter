using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMouseLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rotateToMousePos ();
	}
	void rotateToMousePos()
	{
		Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition + Vector3.forward * 10.0f);
		float angle = angleBtwnPoints (transform.position, mouseWorldPos);

		transform.rotation = Quaternion.Euler (new Vector3(0f,0f,angle-33.0f));
	}

	float angleBtwnPoints(Vector2 a, Vector2 b)
	{
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
		
	}
}

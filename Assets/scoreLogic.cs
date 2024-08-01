﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	

public class scoreLogic : MonoBehaviour {

	public int score = 0;
	Text txt;

	// Use this for initialization
	void Start () 
	{
		txt = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		printScore ();
		
	}

	public void addToScoreVOID()
	{
		score++;
		printScore ();
	}

	public void printScore()
	{
		txt.text = "SCORE: " + score;
	}
}

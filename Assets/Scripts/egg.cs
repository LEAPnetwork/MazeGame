﻿using UnityEngine;
using System.Collections;

public class egg : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider col)
	{

		Destroy (gameObject);
	}
}
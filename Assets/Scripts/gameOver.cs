using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.anyKeyDown) {
			Destroy (gameObject, 0.1f);
			Application.LoadLevel (0);
		}
	}
}

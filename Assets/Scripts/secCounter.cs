using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class secCounter : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Text> ().text = "Seconds: " + (int)Time.time;
	}
}

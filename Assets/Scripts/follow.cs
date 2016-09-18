using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour
{

	public GameObject target;
	public Vector3 offset;


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		transform.LookAt (target.transform.position + Vector3.down);
		transform.position = target.transform.position + offset;
	}
}

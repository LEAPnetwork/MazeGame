using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour
{

	public float force;
	public float drag;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		GetComponent<Rigidbody> ().AddForce (new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * force);
	}
}

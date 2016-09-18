using UnityEngine;
using System.Collections;

public class ArtificialInteligenceFSM : MonoBehaviour
{

	public GameObject player;

	public float look;
	public float chase;
	public float speed;


	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Vector3.Distance (this.player.transform.position, this.transform.position) < this.look)     
			this.transform.LookAt (this.player.transform.position);
		if (Vector3.Distance (this.player.transform.position, this.transform.position) < this.chase)     
			GetComponent<Rigidbody> ().velocity = transform.forward * speed;
		else 
			GetComponent<Rigidbody> ().velocity *= 0.9f;

	}
}

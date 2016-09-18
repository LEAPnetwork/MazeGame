using UnityEngine;
using System.Collections;

public class cannon : MonoBehaviour
{

	public GameObject CannonBall;
	public float delay;
	public float ballSpeed;
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine (shoot (delay));

	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	IEnumerator shoot (float d)
	{
		while (true) {
			yield return new WaitForSeconds (d);
			GameObject obj = Instantiate (CannonBall, this.transform.position, this.transform.rotation) as GameObject;
			obj.GetComponent<Rigidbody> ().velocity = transform.forward * ballSpeed;
		}
	}
}

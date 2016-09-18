using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);

          GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");

            foreach(GameObject egg in eggs)
            {
                Destroy(egg);
            }
        }
    }
}

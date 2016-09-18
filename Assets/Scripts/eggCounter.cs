using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class eggCounter : MonoBehaviour
{

	public float numOfEgg;
	public GameObject[] Eggs;
	public GameObject gameOverPrefab;
    public GameObject GameOverCamera;

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Eggs = GameObject.FindGameObjectsWithTag ("Egg");
		numOfEgg = Eggs.Length;

		if (Eggs.Length == 0 && gameOverPrefab != null) {
			Debug.Log ("No eggs");
			GameObject obj = Instantiate (gameOverPrefab) as GameObject;
            
			obj.transform.parent = GameObject.Find ("GUI").transform;
			obj.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0, 0);

			Destroy (gameObject);

            GameOverCamera.SetActive(true);
		}
		
		GetComponent<Text> ().text = "" + numOfEgg + " Eggs left";

	}
}

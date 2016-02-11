using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float data = 0;
	// Use this for initialization
	void Start () {

		Debug.Log ("Personaje en pantalla");
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (data, 3, 0);
	}
}

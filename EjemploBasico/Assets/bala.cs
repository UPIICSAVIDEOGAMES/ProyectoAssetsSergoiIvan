using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {

	private Vector3 balaposition;
	// Use this for initialization
	void Start () {
		balaposition = new Vector3 (0.05f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += balaposition;
	}
}

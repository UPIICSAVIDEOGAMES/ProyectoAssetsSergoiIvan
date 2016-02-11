using UnityEngine;
using System.Collections;

public class Tiburon : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition -= new Vector3 (0.05f, 0, 0);
	}
}

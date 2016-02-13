using UnityEngine;
using System.Collections;

public class robot : MonoBehaviour {

	public Transform bala;
	private Vector3 position;
	//private Vector3 positionBala;
	// Use this for initialization
	void Start () {
		position = new Vector3 (0.05f, 0, 0);
		//positionBala = new Vector3 (0.05f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.localPosition.x >= 5) {
			position.x *= -1;
			Instantiate(bala, transform.localPosition, Quaternion.identity); 
		}
		else {
			transform.localPosition += position;
		}



	}
}

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float data = 1;
	public Transform enemigo;
	private Vector3 incremento;

	// Use this for initialization
	void Start () {

		Debug.Log ("Personaje en pantalla");
		incremento = new Vector3 (0.05f, 0, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x>=5.5)
		{
			incremento.x *= -1;

			Instantiate(enemigo, transform.localPosition, Quaternion.identity); // Aparecer el tiburon cuando este en cierta posición 
			//transform.Rotate(Vector3.right,Time.deltaTime);
		}
		/*if (transform.localPosition.x <= 5 ) {
			incremento.x *= 1;
			//transform.Rotate(Vector3.left,Time.deltaTime);
		}*/
		GetComponent<Transform> ().localPosition += incremento;
	}
}

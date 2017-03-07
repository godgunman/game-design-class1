using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	// Use this for initialization
	// private Transform myTransForm;
	private Rigidbody2D myRigibody2D;
	public ScoreManager scoreManager;

	void Start () {
		//myTransForm = this.GetComponent<Transform> ();
		myRigibody2D = this.GetComponent<Rigidbody2D> ();
	}

	//public float speed = 10;
	public float forceValue;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
			//myTransForm.position += new Vector3 (0, speed * Time.deltaTime, 0);
			myRigibody2D.AddForce(new Vector2(0, forceValue));
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			//myTransForm.position += new Vector3 (0, speed * Time.deltaTime, 0);
			myRigibody2D.AddForce(new Vector2(0, -forceValue));
		}
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			//myTransForm.position += new Vector3 (0, speed * Time.deltaTime, 0);
			myRigibody2D.AddForce(new Vector2(-forceValue, 0));
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			//myTransForm.position += new Vector3 (0, speed * Time.deltaTime, 0);
			myRigibody2D.AddForce(new Vector2(forceValue, 0));
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.SetActive (false);
		// Debug.Log (other);
		scoreManager.AddScore(1);
	}
}

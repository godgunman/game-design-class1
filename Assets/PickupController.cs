using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float rotateSpeep = 1;

	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (0, 0, rotateSpeep * Time.deltaTime));
	}
}

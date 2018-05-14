using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsRatation : MonoBehaviour {

	float speed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * speed * Time.deltaTime);
	}
}

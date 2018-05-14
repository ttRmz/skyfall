using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    float MultSpeed = 2000;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float Speed = Time.deltaTime * MultSpeed;

        Rigidbody r = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.LeftArrow))
            r.AddForce(new Vector3(-Speed, 0, 0));
        if (Input.GetKey(KeyCode.RightArrow))
            r.AddForce(new Vector3(Speed, 0, 0));

	}
}

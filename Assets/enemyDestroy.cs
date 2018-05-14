using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroy : MonoBehaviour {
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}

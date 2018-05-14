using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {
	public float range = 7f;    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }

    void Start (){
		transform.position = new Vector3(Random.Range(-range, range), 20f, 0.12f); 
    }
}

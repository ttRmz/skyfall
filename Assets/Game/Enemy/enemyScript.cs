using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    private bool Catch = false;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
            Catch = true;
            GameObject.Find("Plate").GetComponent<scoreDetection>().checkIsAlive(Catch);
        }
    }

    void Start (){
		transform.position = new Vector3(Random.Range(-8.2f, 7.7f), 20f, 0.12f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDetection : MonoBehaviour {

	[SerializeField]
	private int score = 0;

	void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Enemy")
        {
            score ++;
			GameObject.Find("Canvas").GetComponent<canvasScript>().MajScore(score);
        }
    }
}

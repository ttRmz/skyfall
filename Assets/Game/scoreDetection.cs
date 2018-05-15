using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDetection : MonoBehaviour {

	[SerializeField]
	private int score = 0;

    private bool isAlive = true;

    public void checkIsAlive (bool killed){
        if(killed == true){
            isAlive = false;
        }else
        {
            isAlive = true;
        }
    }

	void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Enemy" && isAlive == true)
        {
            score ++;
			GameObject.Find("Canvas").GetComponent<canvasScript>().MajScore(score);
        }
        if(isAlive == false){
            GameObject.Find("Canvas").GetComponent<canvasScript>().youreDead("You are dead. press 'r' to retry");
        }
    }
}

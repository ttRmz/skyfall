using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasScript : MonoBehaviour {

	public Text txtscore;
	public void MajScore (int sc) {
		txtscore.text = sc.ToString();
	}

    public Text youDead;
    public void youreDead( string mess){
        youDead.text = mess;
    }

}

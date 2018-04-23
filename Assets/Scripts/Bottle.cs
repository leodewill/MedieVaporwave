using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            this.transform.SetParent(col.transform);
            this.transform.position = col.transform.GetChild(0).position;
            this.transform.eulerAngles = new Vector3(-col.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCadeado : MonoBehaviour {

    bool up = false;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (up) {
            this.transform.parent.position += speed * Time.deltaTime * Vector3.up;
        }
	}

    public void fly() {
        up = true;
        Invoke("Die", 4.0f);
    }

    void Die() {
        Destroy(this.transform.parent.gameObject);
    }
}

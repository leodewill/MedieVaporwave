using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject target;
    Vector3 destiny;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destiny = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position).normalized * 100.0f;
        target.transform.localPosition = Vector3.Lerp(target.transform.position, destiny, 0.2f);
	}
}

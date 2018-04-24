using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaButton : Clickable {

    public Animator gaveta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClick(int mouseButton) {
        if (mouseButton == 0) {
            gaveta.SetTrigger("Show");
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPick : Clickable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClick(int mouseButton) {
        if (mouseButton == 0) {
            GameManager.instance.lockpickLvl = 1;
            Destroy(this.gameObject);
        }
    }
}

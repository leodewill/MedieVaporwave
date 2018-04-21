using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : Clickable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnPointerEnter() {
        Debug.Log("Pointer Enter");
    }

    public override void OnPointerExit() {
        Debug.Log("Pointer Exit");
    }

    public override void OnClick(int mouseButton) {
        Debug.Log("click button " + mouseButton);
    }

    public override void OnDrag() {
        Debug.Log("Drag");
    }

    public override void OnDrop() {
        Debug.Log("Drop");
    }
}

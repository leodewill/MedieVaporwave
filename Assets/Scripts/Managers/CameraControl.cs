using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    
    bool moving = false;
    FocusTarget target;
	
	// Update is called once per frame
	void Update () {
        if (moving && this.transform.position != target.transform.position + target.offset)
            this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + target.offset, 0.3f);
        else
            moving = false;
	}

    public void changeTarget(FocusTarget t) {
        if (target != null)
            target.haveFocus = false;
        moving = true;
        target = t;
        target.haveFocus = true;
    }
}
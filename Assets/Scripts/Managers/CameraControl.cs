using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class CameraControl : MonoBehaviour {
    
    public bool moving = false;
    FocusTarget target;
    FreeLookCam lookScript;

    void Awake() {
        lookScript = this.GetComponent<FreeLookCam>();
    }

	// Update is called once per frame
	void Update () {
        if (moving) {
            if (this.transform.position != target.transform.position + target.offset)
                this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + target.offset, 0.3f);

            if (target != FocusTarget.main && this.transform.rotation != Quaternion.Euler(target.ajust) * target.transform.rotation)
                this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(target.ajust) * target.transform.rotation, 0.3f);
        }
	}

    public void changeTarget(FocusTarget t) {
        if (target != null)
            target.haveFocus = false;
        moving = true;

        if (t != FocusTarget.main)
            lookScript.enabled = false;
        else
            lookScript.enabled = true;
        target = t;
        target.haveFocus = true;
    }
}
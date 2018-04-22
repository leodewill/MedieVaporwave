using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable {

    public LockPickable lockScript;
    public Animator tampa;

    void Awake() {
        lockScript = this.GetComponent<LockPickable>();
        if (lockScript != null)
            lockScript.item = this;
    }

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () { }

    public override void OnLocked() {
        lockScript.TryUnlock();
    }

    public override void Interact() {
        tampa.SetTrigger("Move");
    }
}

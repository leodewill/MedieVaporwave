using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable {

    public LockPickable lockScript;
    public Animator tampa;
    public Animator cadeado, ferro;

    void Awake() {
        lockScript = this.GetComponent<LockPickable>();
        if (lockScript != null)
            lockScript.item = this;

        //locked = true;
    }

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () { }

    public override void OnLocked() {
        if (lockScript != null)
            lockScript.TryUnlock(cadeado);
    }

    public override void OnUnlock() {
        Invoke("Interact", 1.0f);
    }

    public override void Interact() {
        tampa.SetTrigger("Open");
    }

    public override void Close() {
        tampa.SetTrigger("Close");
    }
}
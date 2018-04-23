using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moldura : Interactable {

    public LockPickable lockScript;
    public Animator cadeado;

    void Awake() {
        lockScript = this.GetComponent<LockPickable>();
        if (lockScript != null)
            lockScript.item = this;

        locked = true;
    }

    // Use this for initialization
    void Start () { }

    // Update is called once per frame
    void Update() { }

    public override void OnLocked() {
        lockScript.TryUnlock(cadeado);
    }

    public override void OnUnlock() {
        Invoke("Interact", 1.0f);
    }

    public override void Interact() {
    }

    public override void Close() {
    }
}
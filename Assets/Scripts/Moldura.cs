using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moldura : Interactable {

    public LockPickable lockScript;
    public Animator cadeado;
    public Mesa mesa;
    public int lvl;
    public PaintCadeado disk;
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
        
    }

    public override void Interact() {
        if (GameManager.instance.diskLvl >= lvl) {
            mesa.turnOn();
            GameManager.instance.diskLvl++;
            disk.fly();
        }
    }

    public override void Close() {
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickable : MonoBehaviour {

    public Interactable item;
    public int lvl;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void TryUnlock(Animator cadeado) {
        if (GameManager.instance.lockpickLvl == lvl) {
            item.Unlock();
            item.OnUnlock();
            cadeado.SetTrigger("Fly");
        } else if (cadeado != null)
            cadeado.SetTrigger("Touch");
    }
}
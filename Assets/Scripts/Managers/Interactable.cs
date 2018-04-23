using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public bool locked;

    public void Touch() {
        if (!locked)
            Interact();
        else
            OnLocked();
    }

    public void Left() {
        if (!locked)
            Close();
        else
            GiveUp();
    }

    public void Unlock() {
        locked = false;
        OnUnlock();
    }

    public void Lock() {
        locked = true;
        OnLock();
    }

    public virtual void Interact() { }
    public virtual void OnLocked() { }
    public virtual void OnUnlock() { }
    public virtual void OnLock() { }
    public virtual void Close() { }
    public virtual void GiveUp() { }
}

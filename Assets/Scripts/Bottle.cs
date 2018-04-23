using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {

    Vector3 originalPos;
    Transform mesa;
    public GameObject lockPick, solid, liquid, plasma;
	// Use this for initialization
	void Awake () {
        originalPos = this.transform.position;
        mesa = this.transform.parent;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void letOnTable() {
        this.transform.SetParent(mesa);
        this.transform.position = originalPos;
        if (!GameManager.instance.cutscene)
            Invoke("explode", 0.5f);
    }

    public void explode() {
        Destroy(solid);
        Destroy(liquid);
        plasma.SetActive(true);
        lockPick.SetActive(true);
        Invoke("Die", 1.0f);
    }

    void Die() {
        Destroy(plasma);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player" && GameManager.instance.cutscene) {
            this.transform.SetParent(col.transform);
            this.transform.position = col.transform.GetChild(0).position;
            this.transform.localEulerAngles = col.transform.GetChild(0).localEulerAngles;
        }
    }
}
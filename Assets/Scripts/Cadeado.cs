using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadeado : MonoBehaviour {

    public GameObject fire, explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartFire() {
        fire.SetActive(true);
    }

    public void Explode() {
        this.GetComponent<MeshRenderer>().enabled = false;
        this.transform.GetChild(0).gameObject.SetActive(false);
        explosion.SetActive(true);
    }

    public void Die() {
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaveta : Clickable {

    public int lvl;
    public GameObject janela;
	// Use this for initialization
	void Start () {
        janela.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClick(int mouseButton) {
        if (mouseButton == 0) {
            janela.SetActive(true);
            this.GetComponent<BoxCollider>().enabled = false;
        }
        
    }
}

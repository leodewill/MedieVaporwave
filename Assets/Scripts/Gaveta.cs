using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaveta : Clickable {

    public int lvl;
    public SpriteRenderer janela;
	// Use this for initialization
	void Start () {
        janela.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClick(int mouseButton) {
        if (mouseButton == 0) {
            janela.color = Color.white;
            this.GetComponent<BoxCollider>().enabled = false;
        }
        
    }
}

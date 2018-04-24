using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : Clickable {

    public static bool[] rightPlace;
    public char color;
    Vector3 pos, rot;
    public bool receiver;
    public int index;
    MeshRenderer rend;

	// Use this for initialization
	void Start () {
        rightPlace = new bool[4];
        for (int i = 0; i < 4; i++)
            rightPlace[i] = false;

        pos = this.transform.position;
        rot = this.transform.eulerAngles;
        rend = this.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (receiver && rightPlace[0] && rightPlace[1] && rightPlace[2] && rightPlace[3])
            GameManager.instance.openGate();
	}

    public void reset() {
        this.transform.position = pos;
        this.transform.eulerAngles = rot;
        rend.enabled = true;
    }

    public override void OnClick(int mouseButton) {
        if (mouseButton == 0) {
            if (!receiver) {
                if (GameManager.instance.holdBook != this) {
                    if (GameManager.instance.holdBook != null)
                        GameManager.instance.holdBook.reset();
                    GameManager.instance.holdBook = this;
                    rend.enabled = false;
                }
            } else {
                if (GameManager.instance.holdBook != null) {
                    if (GameManager.instance.holdBook.color != color)
                        GameManager.instance.holdBook.reset();
                    else {
                        GameManager.instance.holdBook.transform.position = this.transform.position;
                        GameManager.instance.holdBook.transform.eulerAngles = this.transform.eulerAngles;
                        rend.enabled = true;
                        rightPlace[index] = true;
                        GameManager.instance.holdBook = null;
                    }
                }
            }
        }
    }
}
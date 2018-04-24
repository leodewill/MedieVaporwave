using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Typer : Clickable {

    public static int[] sequel;
    public static int index = 0;
    public int value;
    public bool ctrl = false;

	// Use this for initialization
	void Start () {
        sequel = new int[4];
        sequel[0] = 3;
        sequel[1] = 1;
        sequel[2] = 8;
        sequel[3] = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (index == 4){
            GameManager.instance.cam.changeTarget(FocusTarget.main);
            Invoke("EndGame", 10.0f);
            GameManager.instance.sala.SetTrigger("Trigger");
        }
	}

    void EndGame(){
        SceneManager.LoadScene("Menu");
    }

    public override void OnClick(int mouseButton) {
        if (mouseButton == 0 && !ctrl) {
            if (sequel[index] == value) {
                index++;
                Debug.Log("yes");
            } else
                index = 0;
        }   
    }
}

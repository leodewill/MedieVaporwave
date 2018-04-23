using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fist : MonoBehaviour {

    public GameObject aesthetics;
    public Image black;
    public Bottle bottle;
    public Animator hand;
    bool clear = false;
    public FocusTarget mesa;

    // Use this for initialization
    void Start () {
        aesthetics.SetActive(false);
        black.gameObject.SetActive(false);
        if (!GameManager.instance.cutscene)
            bottle.letOnTable();
    }

	// Update is called once per frame
	void Update () {
        if (clear) {
            if (black.color != Color.clear)
                black.color = Color.Lerp(black.color, Color.clear, 0.05f);
            else {
                black.gameObject.SetActive(false);
                clear = false;
            }
        }
	}
    public void startCutscene() {
        GameManager.instance.cam.changeTarget(mesa);
        hand.SetBool("Holding", true);
    }

    public void showAesthetics() {
        aesthetics.SetActive(true);
    }

    public void hideAesthetics() {
        aesthetics.SetActive(false);
    }

    public void letBottle() {
        aesthetics.SetActive(false);
        bottle.letOnTable();
        hand.SetBool("Holding", false);
        black.gameObject.SetActive(true);
        GameManager.instance.cam.changeTarget(FocusTarget.main);
    }

    public void explodeBottle() {
        bottle.explode();
    }

    public void OpenEyes() {
        clear = true;
        GameManager.instance.startGame();
    }
}
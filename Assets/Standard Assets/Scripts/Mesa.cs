using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesa : MonoBehaviour {

    public GameObject[] leds;
    public GameObject button;
    bool on = false;
    float startTime, currTime;
    int index = 0;
	// Use this for initialization
	void Start () {
        leds[0].transform.parent.gameObject.SetActive(false);
        leds[1].transform.parent.gameObject.SetActive(false);
        button.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (on) {
            currTime = Time.time;
            if (currTime - startTime >= 1.0f) {
                leds[index].SetActive(false);
                leds[1 - index].SetActive(true);
                index = 1 - index;
                startTime = Time.time;
            }
        }
	}

    public void turnOn() {
        on = true;
        leds[0].transform.parent.gameObject.SetActive(true);
        leds[1].transform.parent.gameObject.SetActive(true);
        leds[1].SetActive(false);
        button.SetActive(true);
        startTime = Time.time;
    }
}

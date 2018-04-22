using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject[] tabs;

	// Use this for initialization
	void Start () {
        Clear();
        tabs[0].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Clear() {
        foreach (GameObject g in tabs)
            g.SetActive(false);
    }

    public void Play() {
        SceneManager.LoadScene("Game");
    }

    public void Quit() {
        Application.Quit();
    }

    public void ChangeTab(GameObject tab) {
        Clear();
        tab.SetActive(true);
    }
}
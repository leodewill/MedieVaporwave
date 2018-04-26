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

    public void Return() {
        SceneManager.LoadScene("Menu");
    }

    public void Quit() {
        Application.Quit();
    }

    public void ChangeTab(GameObject tab) {
        Clear();
        tab.SetActive(true);
    }

    public void Pause(GameObject menu) {
        Clear();
        tabs[0].SetActive(true);
        menu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Resume(GameObject menu) {
        menu.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public static CameraControl cam;
    public static bool paused = false;
    Menu menu;
    public GameObject menuInGame;

	// Use this for initialization
	void Start () {
        menu = this.GetComponent<Menu>();
        menuInGame.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!paused)
                menu.Pause(menuInGame);
            else
                menu.Resume(menuInGame);

            paused = !paused;
        }
	}
}
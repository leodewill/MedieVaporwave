using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public CameraControl cam;
    public static bool paused = false;
    [Space(10)]
    public int lockpickLvl = 0;
    Menu menu;
    public GameObject menuInGame;
    public Animator fist;
    public bool cutscene;
    void Awake() {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        if (cutscene) {
            cam.GetComponent<Raycaster>().enabled = false;
            cam.GetComponent<FreeLookCam>().enabled = false;
        } else
            fist.enabled = false;
      
    }

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

    public void startGame() {
        cam.GetComponent<Raycaster>().enabled = true;
        cam.GetComponent<FreeLookCam>().enabled = true;
    }
}
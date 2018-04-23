using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public static CameraControl cam;
    public static bool paused = false;
    [Space(10)]
    public int lockpickLvl = 0;
    Menu menu;
    public GameObject menuInGame;
    public Animator hand;
    public bool canPlay = false;
    public FocusTarget mesa;
    void Awake() {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

	// Use this for initialization
	void Start () {
        menu = this.GetComponent<Menu>();
        menuInGame.SetActive(false);
        hand.SetBool("Holding", true);
        //cam.changeTarget(mesa);
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
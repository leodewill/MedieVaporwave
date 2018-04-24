using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MusicProgression : MonoBehaviour {

    public AudioSource music;

    public AudioClip MusicBegin;
    public AudioClip MusicWave_One;
    public AudioClip MusicWave_Two;
    public AudioClip MusicWave_Three;
    public AudioClip MusicWave_Four;

    public int stage;
    private int currstage;

    // Use this for initialization
    void Start () {
        music = GetComponent<AudioSource>();

        music.loop = true;
        music.clip = MusicBegin;
        music.Play();
	}
	
	// Update is called once per frame
	void Update () {

        MusicDecide();

	}
    private void MusicDecide()
    {
        if (stage == 1)
        {
            music.clip = MusicWave_One;
        }
        else if (stage == 2)
        {
            music.clip = MusicWave_Two;
        }
        else if (stage == 3)
        {
            music.clip = MusicWave_Three;
        }
        else if (stage == 4)
        {
            music.clip = MusicWave_Four;
        }
        if (stage >= 0)
        {
            music.Play();
            stage = -1;
        }
    }
}

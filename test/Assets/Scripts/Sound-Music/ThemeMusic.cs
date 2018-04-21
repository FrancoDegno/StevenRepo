using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeMusic : MonoBehaviour {
    [SerializeField]
    AudioSource audio;
    [SerializeField]
    AudioClip clip;

    bool stopChange = false;

	// Use this for initialization
	void Start () {
        audio =GetComponent<AudioSource>();
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (!audio.isPlaying && !stopChange)
        {
            audio.clip = clip;
            audio.loop = true;
            audio.Play();
            stopChange = true;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAserAudioManager : MonoBehaviour {

    [SerializeField]
    GameObject charge;
    [SerializeField]
    GameObject laser;

    AudioSource audio;

    AudioClip audioCharge;
    AudioClip audioShoot;

    void Awake()
    {
        audio = gameObject.AddComponent<AudioSource>() as AudioSource;
    }

    bool active = true;


    void OnEnable()
    {
        active = true;
        audio.clip = audioCharge;
        audio.loop = true;
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
        if(laser.activeInHierarchy && active)
        {
            active = false;
            audio.loop = false;
            audio.Stop();
            audio.PlayOneShot(audioShoot);


        }

	}
}

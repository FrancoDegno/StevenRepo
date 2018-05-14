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

    public void setAudioCharge(AudioClip clip)
    {
        audioCharge = clip;
    }

    public void setAudioShoot(AudioClip clip)
    {
        audioShoot = clip;
    }

    bool active = true;


    void OnEnable()
    {
        active = true;
        if (audioCharge != null) {
            print("play");
            audio.clip = audioCharge;
            audio.loop = true;
            audio.Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
        if(audioShoot!=null && laser.activeInHierarchy && active)
        {
            print("play2");
            active = false;
            audio.loop = false;
            audio.Stop();
            audio.PlayOneShot(audioShoot);


        }

	}
}

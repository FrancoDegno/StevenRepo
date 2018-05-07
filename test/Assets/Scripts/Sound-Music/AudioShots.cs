using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioShots : MonoBehaviour {

    // Use this for initialization
    AudioClip singleShot;
    AudioClip tripleShot;
    AudioClip superShot;

    AudioSource audio;

    void Start () {
        audio = gameObject.AddComponent<AudioSource>() as AudioSource;
        audio.loop = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setSingleAudio(AudioClip s)
    {
        singleShot = s;
    }

    public void setTripleAudio(AudioClip s)
    {
        tripleShot = s;
    }

    public void setsuperAudio(AudioClip s)
    {
        superShot = s;
    }


    public void playSingleAudio()
    {
        if(singleShot!=null)
            audio.PlayOneShot(singleShot);
    }

    public void playTripleAudio()
    {
        if(tripleShot!=null)
            audio.PlayOneShot(tripleShot);
    }

    public void playSuperAudio()
    {
        if(superShot!=null)
            audio.PlayOneShot(superShot);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioShots : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    AudioClip singleShot;
    [SerializeField]
    AudioClip tripleShot;
    [SerializeField]
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
        audio.PlayOneShot(singleShot);
    }

    public void playTripleAudio()
    {
        audio.PlayOneShot(tripleShot);
    }

    public void playSuperAudio()
    {
        audio.PlayOneShot(superShot);
    }

}

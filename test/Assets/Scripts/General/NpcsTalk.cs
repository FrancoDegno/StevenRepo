using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;



public class NpcsTalk : MonoBehaviour {

    [SerializeField]
    TextAsset msg;
	string messege;
	[SerializeField]
	Text text;
	[SerializeField]
	float delayLetter;
	[SerializeField]
	AudioClip clipSound;
	AudioSource audio;

	int index=0;
	// Use this for initialization


	void Start()
	{
        
        messege = msg.text;
        audio = gameObject.AddComponent<AudioSource>() as AudioSource;
		write ();

	}


	void write () {
		if(index<messege.Length)
			StartCoroutine (writeLetter());
	}

	IEnumerator writeLetter()
	{
		yield return new WaitForSeconds (delayLetter);
        text.text += messege [index];
		if (clipSound != null && messege[index]!=' ')
			this.audio.PlayOneShot (clipSound);
		index++;
		write ();
	}

}

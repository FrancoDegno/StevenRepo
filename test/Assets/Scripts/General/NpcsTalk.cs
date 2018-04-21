using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;


public class NpcsTalk : MonoBehaviour {

	[SerializeField]
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
		audio = new AudioSource ();
		print ("Ready and go");
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
		if (clipSound != null)
			this.audio.PlayOneShot (clipSound);
		index++;
		write ();
	}

}

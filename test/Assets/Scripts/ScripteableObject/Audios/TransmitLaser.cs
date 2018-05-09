using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitLaser : MonoBehaviour {
    [SerializeField]
    LaserAudio audio;

    LAserAudioManager transmit;
  

	// Use this for initialization
	void Awake () {
        transmit = GetComponent<LAserAudioManager>();
        transmit.setAudioCharge(audio.chargeAudio);
        transmit.setAudioShoot(audio.laserShoot);
        StartCoroutine(transmitAudiOpt());
    }

    IEnumerator transmitAudiOpt()
    {
        yield return new WaitForSeconds(0.5f);
        AudioSource manager = GetComponent<AudioSource>();
        manager.volume = audio.Volume;
        manager.pitch = audio.Pitch;
    }

}

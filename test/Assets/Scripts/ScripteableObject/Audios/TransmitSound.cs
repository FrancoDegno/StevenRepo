using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitSound : MonoBehaviour {

    [SerializeField]
    PlayerAudio audio;

    AudioShots transmit;

    void Awake()
    {

        transmit = GetComponent<AudioShots>();
        transmit.setSingleAudio(audio.SingleShot);
        transmit.setTripleAudio(audio.TripleShot);
        transmit.setsuperAudio(audio.SuperShot);
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

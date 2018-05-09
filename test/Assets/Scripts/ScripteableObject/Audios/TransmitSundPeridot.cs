using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitSundPeridot : MonoBehaviour {

    [SerializeField]
    EnemyAudio audio;

    AudioShots transmit;

    void Awake()
    {

        transmit = GetComponent<AudioShots>();
        transmit.setSingleAudio(audio.singleAudio);
        transmit.setTripleAudio(audio.TripleAudio);
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

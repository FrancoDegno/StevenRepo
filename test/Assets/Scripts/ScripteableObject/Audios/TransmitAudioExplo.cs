using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitAudioExplo : MonoBehaviour {
    [SerializeField]
    ExploAudio audio;

    Explotion transmit;

    void Awake()
    {
        transmit=GetComponent<Explotion>();
        transmit.getAudio(audio.Explo);
        StartCoroutine(transmitAudiOpt());
    }


    IEnumerator transmitAudiOpt()
    {
        yield return new WaitForEndOfFrame();
        AudioSource manager=GetComponent<AudioSource>();
        manager.volume = audio.Volume;
        manager.pitch = audio.Pitch;
    }
}

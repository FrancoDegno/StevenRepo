using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitAudioExplo : MonoBehaviour {
    [SerializeField]
    ExploAudio audio;
    Explotion transmit;

    void Awake()
    {
        transmit.getAudio(audio.Explo);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitSound : MonoBehaviour {

    [SerializeField]
    PlayerAudio data;
    AudioShots scriptToTransmit;

    void Awake()
    {

        scriptToTransmit = GetComponent<AudioShots>();
        scriptToTransmit.setSingleAudio(data.SingleShot);
        scriptToTransmit.setTripleAudio(data.TripleShot);
        scriptToTransmit.setsuperAudio(data.SuperShot);
    }



}

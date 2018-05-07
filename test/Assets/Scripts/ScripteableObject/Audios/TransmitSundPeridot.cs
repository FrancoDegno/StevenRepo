using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitSundPeridot : MonoBehaviour {

    [SerializeField]
    EnemyAudio data;
    AudioShots scriptToTransmit;

    void Awake()
    {

        scriptToTransmit = GetComponent<AudioShots>();
        scriptToTransmit.setSingleAudio(data.singleAudio);
        scriptToTransmit.setTripleAudio(data.TripleAudio);
    }
}

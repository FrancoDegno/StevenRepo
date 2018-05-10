using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="GreenShip",menuName ="CreateAudio/EnemyShip/PeridotShip")]
public class EnemyAudio : ScriptableObject {
    public AudioClip singleAudio;
    public AudioClip TripleAudio;
    [Range(0, 1)]
    public float Volume;
    [Range(-3, 3)]
    public float Pitch;

}

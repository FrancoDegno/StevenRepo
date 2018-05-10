using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerLars", menuName = "CreateAudio/PlayerShips/Lars")]
public class PlayerAudio : ScriptableObject{
    public AudioClip SingleShot;
    public AudioClip TripleShot;
    public AudioClip SuperShot;

    [Range(0, 1)]
    public float Volume;
    [Range(-3, 3)]
    public float Pitch;

}

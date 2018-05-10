using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="LaserAudio",menuName = "CreateAudio/LaserAudio")]
public class LaserAudio : ScriptableObject {

    public AudioClip chargeAudio;
    public AudioClip laserShoot;

    [Range(0, 1)]
    public float Volume;
    [Range(-3, 3)]
    public float Pitch;

}

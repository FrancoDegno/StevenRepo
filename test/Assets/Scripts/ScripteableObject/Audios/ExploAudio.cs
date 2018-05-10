using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="ExploSound",menuName = "CreateAudio/Explotions/ExplotionSound")]
public class ExploAudio : ScriptableObject {
    public AudioClip Explo;
    [Range(0, 1)]
    public float Volume;
    [Range(-3, 3)]
    public float Pitch;
}

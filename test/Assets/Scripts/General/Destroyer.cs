using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	[SerializeField]
	float TimerDestroy;


	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, TimerDestroy);
	}
	

}

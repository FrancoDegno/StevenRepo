using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLess : MonoBehaviour {
    [SerializeField]
    ReciveDmg playerDmg;
    Animator lifes;
    [SerializeField]
    float divideBy = 50;
	// Use this for initialization
	void Start () {
        lifes = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (playerDmg)
            lifes.SetInteger("state", (int)(playerDmg.realHp / divideBy));
        else
            lifes.SetInteger("state", 0);


    }
}

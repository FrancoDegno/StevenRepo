using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour {
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject victory;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (MySingleClass.fGame && player)
        { 
            victory.SetActive(true);
            Destroy(this);
        }
    }
}

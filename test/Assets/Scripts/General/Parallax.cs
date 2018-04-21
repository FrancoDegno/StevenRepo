using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {


    public float speed;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.Translate(Vector2.left * speed*Time.deltaTime*MySingleClass.SpeedTimer);
        
	}
}

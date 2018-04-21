using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrousel : MonoBehaviour {

	// Use this for initialization
	public Transform startObject;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) 
	{

		Vector3 nPos;
		nPos = other.transform.position;
		nPos.x = startObject.position.x;
		other.transform.position = nPos;
	}


}

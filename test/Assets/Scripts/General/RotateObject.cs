using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {
	

	[SerializeField]
	float ejeX=0;

	[SerializeField]
	float ejeY=0;

	[SerializeField]
	float ejeZ=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.eulerAngles += new Vector3 (ejeX * Time.deltaTime, ejeY * Time.deltaTime, ejeZ * Time.deltaTime);
	}
}

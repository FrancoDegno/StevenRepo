using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour {

    [SerializeField]
    float speed;
    [SerializeField]
    Vector3 MaxScale;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale = Vector3.Lerp(transform.localScale, MaxScale, speed * Time.deltaTime);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readText : MonoBehaviour {

    [SerializeField]
    TextAsset TEXT;
    string tex;

	// Use this for initialization
	void Start () {
        tex = TEXT.text;
        print(tex);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

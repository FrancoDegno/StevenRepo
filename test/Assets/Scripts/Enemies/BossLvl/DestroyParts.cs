using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParts : MonoBehaviour {


    [SerializeField]
    int layer;

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==layer)
        {
            anim.SetBool("broken", true);
        }
    }
}

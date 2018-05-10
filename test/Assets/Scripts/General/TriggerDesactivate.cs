using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDesactivate : MonoBehaviour {
    [SerializeField]
    int layerImpact;
    [SerializeField]
    GameObject objToactDesact;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==layerImpact)
        {
            if (objToactDesact.activeInHierarchy)
                objToactDesact.SetActive(false);
            else
                objToactDesact.SetActive(true);

        }

    }

}

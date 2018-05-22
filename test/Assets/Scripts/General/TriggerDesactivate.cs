using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDesactivate : MonoBehaviour {
    [SerializeField]
    int layerImpact;
    [SerializeField]
    int layerImpact2;
    [SerializeField]
    GameObject objToactDesact;
    [SerializeField]
    GameObject objToactDesact2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==layerImpact || other.gameObject.layer == layerImpact2)
        {
            if (objToactDesact.activeInHierarchy) { 
                objToactDesact.SetActive(false);
                objToactDesact2.SetActive(true);
            }
            else { 
                objToactDesact.SetActive(true);
                objToactDesact2.SetActive(false);
            }
        }

    }

}

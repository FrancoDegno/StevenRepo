using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWDelay : MonoBehaviour {
    [SerializeField]
    float delay;
    [SerializeField]
    GameObject obj;
	// Use this for initialization
	void Start () {
        StartCoroutine(activate());
	}
	
	IEnumerator activate()
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(true);
    }
}

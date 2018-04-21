using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinkRhod : MonoBehaviour {
    [SerializeField]
    Animator anim;

    [SerializeField]
    float tiempoMAX;
    [SerializeField]
    float tiempoMin;
    float value = 0;
	// Use this for initialization
	void Start () {
        StartWink();
	}

    void StartWink()
    {
        value = Random.Range(tiempoMin, tiempoMAX);
        StartCoroutine(winked());

    }
	
	IEnumerator winked()
    {
        yield return new WaitForSeconds(value);
        anim.SetBool("winked1", true);
        anim.SetBool("winked2", true);
        yield return new WaitForSeconds(0.1f);
        anim.SetBool("winked1",false);
        anim.SetBool("winked2",false);

        StartWink();
    }
}

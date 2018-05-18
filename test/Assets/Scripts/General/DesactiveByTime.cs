using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactiveByTime : MonoBehaviour {

    [SerializeField]
    float timer = 10;
    Coroutine coroutine;

    void OnEnable()
    {
        if (coroutine != null)
            StopCoroutine(coroutine);
        coroutine = StartCoroutine(desactive());
    }

    IEnumerator desactive()
    {
        yield return new WaitForSeconds(timer);
        gameObject.SetActive(false);
    }
}

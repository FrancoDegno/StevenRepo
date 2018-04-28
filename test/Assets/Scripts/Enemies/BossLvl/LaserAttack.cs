using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack : MonoBehaviour {
    [SerializeField]
    Transform parentLasers;
    GameObject[] Lasers = new GameObject[4];
    [SerializeField]
    GameObject WarningObj;
    [SerializeField]
    float minDelay;
    [SerializeField]
    float maxDelay;

    float refresh;

    void Start()
    {
        for(int i=0;i<parentLasers.childCount;i++)
        {
            Lasers[i] = parentLasers.GetChild(i).gameObject;
        }
        update1();
    }


	void update1()
    {
        refresh = Random.Range(minDelay, maxDelay);
        StartCoroutine(Update2());

    }
	
	// Update is called once per frame
	IEnumerator Update2 () {
        yield return new WaitForSeconds(refresh);
        WarningObj.SetActive(true);
        Lasers[0].SetActive(true);
        yield return new WaitForSeconds(3);
        Lasers[1].SetActive(true);
        yield return new WaitForSeconds(3);
        Lasers[2].SetActive(true);
        yield return new WaitForSeconds(3);
        Lasers[3].SetActive(true);

        update1();
    }
}

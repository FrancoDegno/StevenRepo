using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilAttack : MonoBehaviour {
    [SerializeField]
    GameObject AttackObjectCamera;


    [SerializeField]
    int misilsToLaunch;
    [SerializeField]
    Transform misilPool;
    GameObject[] misils;

	// Use this for initialization
	void Start () {
        misils = new GameObject[misilPool.childCount];
        
        for(int i=0;i<misils.Length;i++)
        {
            misils[i] = misilPool.GetChild(i).gameObject;
        }
        Invoke("attack", 5);

	}


    void attack()
    {
       
        GameObject[] launchMisils = searchMisils();
        if (launchMisils == null)
            return;

        AttackObjectCamera.SetActive(true);
        StartCoroutine(waitActivate(launchMisils));

    }

    IEnumerator waitActivate(GameObject[] launch)
    {
        yield return new WaitForSeconds(3);
        WarningShip.start = true;
        AttackObjectCamera.SetActive(false);
        for(int i=0;i<launch.Length;i++)
        {
            launch[i].SetActive(true);
        }


    }

    GameObject[] searchMisils()
    {
        List<GameObject> launchMisil = new List<GameObject>();
        int nmisil = 0;
        for(int i=0;i<misils.Length;i++)
        {
            if (!misils[i].activeInHierarchy && launchMisil.Count<4)
                launchMisil.Add(misils[i]);
        }

        if (launchMisil.Count == 4)
            return launchMisil.ToArray();
        else
            return null;
    }




}

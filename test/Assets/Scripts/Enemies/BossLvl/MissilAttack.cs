using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilAttack : MonoBehaviour {
    [SerializeField]
    GameObject AttackObjectCamera;

    [SerializeField]
    int cantMisilsToLaunch=4;
    [SerializeField]
    float timerLaunch;
    [SerializeField]
    Transform misilPool;
    GameObject[] misils;
    public delegate void PauseMisil();
    public static PauseMisil misilPause;

    public delegate void UnPauseMisil();
    public static PauseMisil misilUnPause;


    bool firstAttack = true;
    Coroutine coroutine;
    // Use this for initialization
    void Start () {

        BossShip.stopAllAttack += stopAttacks;

    
        misils = new GameObject[misilPool.childCount];
        
        for(int i=0;i<misils.Length;i++)
        {
            misils[i] = misilPool.GetChild(i).gameObject;
        }

	}


    void OnDestroy()
    {
        BossShip.stopAllAttack -= stopAttacks;
    }

    void stopAttacks()
    {
        if(coroutine != null) { 
            StopCoroutine(coroutine);
            setMisilsCamera();
        }
    }

  

    public void attack()
    {

        GameObject[] launchMisils = searchMisils();
        if (launchMisils == null)
            return;

        if (firstAttack) {
        AttackObjectCamera.SetActive(true);
        firstAttack = false;
        if(misilPause!=null)
            misilPause();

        }

        coroutine = StartCoroutine(waitActivate(launchMisils)); ;
        

    }


    public bool readyToAttack()
    {
        if (searchMisils() != null)

            return true;
        else
            return false;

    }


    void setMisilsCamera()
    {
        AttackObjectCamera.SetActive(false);
        if (misilUnPause != null)
            misilUnPause();
    }
  

    IEnumerator waitActivate(GameObject[] launch)
    {
            yield return new WaitForSeconds(3);
            WarningShip.start = true;
            setMisilsCamera();
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
           
            if (!misils[i].activeInHierarchy && launchMisil.Count< cantMisilsToLaunch)
                launchMisil.Add(misils[i]);
        }

        if (launchMisil.Count == cantMisilsToLaunch)
            return launchMisil.ToArray();
        else
            return null;
    }





}

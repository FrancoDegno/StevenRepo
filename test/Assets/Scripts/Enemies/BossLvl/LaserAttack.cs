using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack : MonoBehaviour {
    [SerializeField]
    float timeToDesactiveLaser = 0.5f;

    [SerializeField]
    Transform parentLasers;
    GameObject[] Lasers = new GameObject[4];
    [SerializeField]
    GameObject WarningObj;
    [SerializeField]
    GameObject[] parts = new GameObject[4];

    float refresh;
    Animator laserAnim;

    void Start()
    {
        for(int i=0;i<parentLasers.childCount;i++)
        {
            Lasers[i] = parentLasers.GetChild(i).gameObject;
        }
        
    }


	public void attack()
    {
        //refresh = Random.Range(minDelay, maxDelay);
        StartCoroutine(Update2());

    }

    public bool readyToAttack()
    {
        if (WarningObj.activeInHierarchy)
            return false;

        return true;
    }

    void laserShoot(int index)
    {
        laserAnim = Lasers[index].GetComponent<Animator>();
        laserAnim.SetBool("shoot", true);
    }

    

	
	// Update is called once per frame
	IEnumerator Update2 () {
        yield return new WaitForSeconds(refresh);
        WarningObj.SetActive(true);

        if (parts[0].activeInHierarchy) { 
        //-----------------Laser 1-----------------
        Lasers[0].SetActive(true);
        yield return new WaitForSeconds(2);
        laserShoot(0);
        yield return new WaitForSeconds(timeToDesactiveLaser);
        Lasers[0].SetActive(false);
        }

        if (parts[1].activeInHierarchy) { 
        //-----------------Laser 2----------------
        yield return new WaitForSeconds(1);
        Lasers[1].SetActive(true);
        yield return new WaitForSeconds(2);
        laserShoot(1);
        yield return new WaitForSeconds(timeToDesactiveLaser);
        Lasers[1].SetActive(false);
        }


        if (parts[2].activeInHierarchy) {
        //-----------------Laser 3-----------------
        yield return new WaitForSeconds(1);
        Lasers[2].SetActive(true);
        yield return new WaitForSeconds(2);
        laserShoot(2);
        yield return new WaitForSeconds(timeToDesactiveLaser);
        Lasers[2].SetActive(false);
        }

        if (parts[3].activeInHierarchy) { 
        //-----------------Laser 4-----------------
        yield return new WaitForSeconds(1);
        Lasers[3].SetActive(true);
        yield return new WaitForSeconds(2);
        laserShoot(3);
        yield return new WaitForSeconds(timeToDesactiveLaser);
        Lasers[3].SetActive(false);
        }

        if (WarningObj!=null)
            WarningObj.SetActive(false);
      
    }
}

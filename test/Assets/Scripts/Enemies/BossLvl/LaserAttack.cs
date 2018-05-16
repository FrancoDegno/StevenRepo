using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack : MonoBehaviour {
    [SerializeField]
    float timeToDesactiveLaser = 0.5f;

    [SerializeField]
    Transform parentLasers;
    [SerializeField]
    GameObject[] Lasers = new GameObject[4];
    [SerializeField]
    GameObject WarningObj;
    [SerializeField]
    GameObject[] parts = new GameObject[4];

    float refresh;
    Animator laserAnim;
    Coroutine courutine;
    void Start()
    {
       
        BossShip.stopAllAttack += stopAttacks;
        for(int i=0;i<parentLasers.childCount;i++)
        {
            Lasers[i] = parentLasers.GetChild(i).gameObject;
        }
        
    }

    void OnDestroy()
    {
        BossShip.stopAllAttack -= stopAttacks;
    }

    void stopAttacks()
    {
        if(courutine!=null)
            StopCoroutine(courutine);
        laserOff();
    }



	public void attack()
    {
       courutine= StartCoroutine(Update2());

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

    void laserOff()
    {
        if (WarningObj != null)
            WarningObj.SetActive(false);
        for(int i=0;i<Lasers.Length;i++)
        {
            if(Lasers[i]!=null)
                Lasers[i].SetActive(false);
        }
    }

	
	// Update is called once per frame
	IEnumerator Update2 () {

        yield return new WaitForSeconds(refresh);
        WarningObj.SetActive(true);

        for (int i=0;i<4;i++)
        {
            if(parts[i].activeInHierarchy)
            {
                Lasers[i].SetActive(true);
                yield return new WaitForSeconds(2);
                laserShoot(i);
                yield return new WaitForSeconds(timeToDesactiveLaser);
                Lasers[i].SetActive(false);

            }

        }

        if (WarningObj!=null)
            WarningObj.SetActive(false);
      
    }
}

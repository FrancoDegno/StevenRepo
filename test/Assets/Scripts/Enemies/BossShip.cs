using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShip :MonoBehaviour {
    LaserAttack laser;
    MissilAttack misil;

    bool attacking = false;
    int a;
    bool stop;


	void Start()
    {
        stop = false;
        laser = GetComponent<LaserAttack>();
        misil = GetComponent<MissilAttack>();
        StartCoroutine(initAtk());
    } 

    void OnDisable()
    {
        stop = true;
    }
    void OnEnable()
    {
        Start();
    }

    
          
    IEnumerator initAtk()
    {
        
        yield return new WaitForEndOfFrame();
        if(!stop)
        StartCoroutine(atk());
    }

    int selectAttack()
    {
        int atk = Random.RandomRange(1, 3);



        if (misil.readyToAttack()&& laser.readyToAttack() && atk==1) { 
            return atk;
        }

        if (laser.readyToAttack() && atk == 2) { 
            atk = 2;
            return atk;
        }
        return 0;

    }

    IEnumerator atk()
    {
        yield return new WaitForSeconds(0.5f);
       
        if (!attacking)
            a= selectAttack();

        yield return new WaitForSeconds(3);

        if (a==1)
        {
            misil.attack();
            attacking = true;
            yield return new WaitForSeconds(3);
           
        }

        if (a == 2) 
            laser.attack();

        attacking = false;
        StartCoroutine(atk());

    }



}

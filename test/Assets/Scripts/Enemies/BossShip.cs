using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShip :MonoBehaviour {
    LaserAttack laser;
    MissilAttack misil;

    bool attacking = false;
    int a;
    [SerializeField]
    bool stop;

    public delegate void StopContinueAttacks();
    public static StopContinueAttacks stopAllAttack;

 

    void OnDisable()
    {

        stopAttacks();

    }

    void stopAttacks()
    {
        stop = true;
        if (stopAllAttack != null)
            stopAllAttack();
    }

    void OnEnable()
    {
        StartAtk();
    }


    void StartAtk()
    {
        stop = false;
        laser = GetComponent<LaserAttack>();
        misil = GetComponent<MissilAttack>();
        StartCoroutine(initAtk());
    } 


          
    IEnumerator initAtk()
    {
        
        yield return new WaitForEndOfFrame();
        StartCoroutine(atk());
    }

    int selectAttack()
    {

        int atk = Random.Range(1, 3);



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

        if (a==1 && !stop)
        {
            misil.attack();
            attacking = true;
            yield return new WaitForSeconds(3);
           
        }

        if (a == 2 && !attacking && !stop) {
            attacking = true;
            laser.attack();
        }

        attacking = false;
        if(!stop)
            StartCoroutine(atk());

    }


    void FixedUpdate()
    {
        if(MySingleClass.fGame)
        {
            stopAttacks();
        }
    }



}

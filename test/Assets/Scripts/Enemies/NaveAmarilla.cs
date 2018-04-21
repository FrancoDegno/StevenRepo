﻿using UnityEngine;
using System.Collections;

public class NaveAmarilla : EnemyShip
{

 
	[SerializeField]
	float Altura = 0;
	[SerializeField]
	float SpeedY=0;


    [SerializeField]
    Transform parentShips;
    [SerializeField]
    Transform[] childShips = new Transform[4];
    [Header("Release Ships")]
    [SerializeField]
    float time;
    [SerializeField]
    bool release = false;


    void Start()
    {
        base.Start();
        restart();
    }

    public override void restart()
    {
        for (int i = 0; i < parentShips.childCount; i++)
        {
            childShips[i].gameObject.SetActive(true);
            childShips[i].parent = parentShips.GetChild(i);
            childShips[i].localPosition = Vector3.zero;
            childShips[i].eulerAngles = new Vector3(0, 0, 180);
            childShips[i].GetComponent<EnemyShip>().restart();
            childShips[i].GetComponent<EnemyShip>().endMov();
       
        }

        base.restart();

    }

   
    public override void MovShip (float speed)
	{
		transform.position += new Vector3 (0, Mathf.Sin (Time.time*SpeedY)*Altura, 0);
		transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
	}
	// Use this for initialization
	
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		MovShip (speed);
        if (release)
            Attack();
	}



    void Attack()
    {
        StartCoroutine(StartAttack());

    }

    IEnumerator StartAttack()
    {
        int i = 0;
        childShips[i].GetComponent<EnemyShip>().startMov();
        childShips[i].parent = null;

        yield return new WaitForSeconds(time);
        i++;
        childShips[i].GetComponent<EnemyShip>().startMov();
        childShips[i].parent = null;

        yield return new WaitForSeconds(time);
        i++;
        childShips[i].GetComponent<EnemyShip>().startMov();
        childShips[i].parent = null;

        yield return new WaitForSeconds(time);
        i++;
        childShips[i].GetComponent<EnemyShip>().startMov();
        childShips[i].parent = null;
    }


}


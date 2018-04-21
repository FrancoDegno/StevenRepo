using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilAnimManager : MonoBehaviour {

    Transform target;
    Animator anim;
    int stateAnim = 0;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("SteBonnieShip").transform;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (target.position.x-5 > transform.position.x) { 
            //transform.root.gameObject.SetActive(false);
            if (stateAnim == 0)
                stateAnim = 5;
            if (stateAnim == 1)
                stateAnim = 6;
            if (stateAnim == 2)
                stateAnim = 7;
            if (stateAnim ==3)
                stateAnim = 8;
            if (stateAnim == 4)
                stateAnim = 9;
        }
        else
        if (target.position.z+2 > transform.position.z && target.position.z-2 < transform.position.z ||
           target.position.y + 1 > transform.position.y && target.position.y - 1 < transform.position.y) { 
            stateAnim = 0;
                  }
                else
                    if (target.position.z < transform.position.z && target.position.y < transform.position.y)
                        stateAnim = 1;
                     else
                          if (target.position.z > transform.position.z && target.position.y < transform.position.y)
                                  stateAnim = 2;
                          else
                            if (target.position.z < transform.position.z && target.position.y > transform.position.y)
                                 stateAnim = 3;
                                  else
                                     if (target.position.z > transform.position.z && target.position.y > transform.position.y)
                                         stateAnim = 4;




        print("position misil :" + transform.position.z);
        print("position ship  :" + target.position.z);
        print(stateAnim);
        anim.SetInteger("state", stateAnim);

    }
}

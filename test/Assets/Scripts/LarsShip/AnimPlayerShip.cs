using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayerShip : MonoBehaviour {

    float axisX;
    float axisY;
    [SerializeField]
    Animator myAnimator;
    [SerializeField]
    Animator propAnimator;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Anim();
	}

    void Anim()
    {
        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");


        if (axisY == 0)
        {
            myAnimator.SetInteger("State", 0);
        }

        if (axisX == 0)
        {
            propAnimator.SetBool("prop", true);
            propAnimator.SetBool("Boost", false);
        }
        else
        if (axisX < 0)
        {
            propAnimator.SetBool("prop", false);
            propAnimator.SetBool("Boost", false);
        }
        else
        {
            propAnimator.SetBool("prop", false);
            if (axisX > 0)
                propAnimator.SetBool("Boost", true);
        }

        if(axisY>0)
            myAnimator.SetInteger("State", 1);
        else
            if(axisY<0)
            myAnimator.SetInteger("State", -1);

    }

}

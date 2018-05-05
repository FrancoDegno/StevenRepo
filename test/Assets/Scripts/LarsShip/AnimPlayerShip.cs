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

    bool accel = false;
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
            
            if (axisX > 0) {
                if (accel) { 
                    propAnimator.SetBool("prop", false);
                    propAnimator.SetBool("Boost", true);
                }
                else
                    propAnimator.SetBool("prop", true);
            }
        }

        if(axisY>0)
            myAnimator.SetInteger("State", 1);
        else
            if(axisY<0)
            myAnimator.SetInteger("State", -1);

    }



    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 12)
        {
            accel = true;
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.layer == 12)
        {
            accel =false;
        }

    }
}

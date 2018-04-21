using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStebonnie : MonoBehaviour {
    [SerializeField]
    Animator myAnim;
	[SerializeField]
	Animator propLeftAnim;
	[SerializeField]
	Animator propRightAnim;
    float axisX;
    float axisY;

	int istate=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");


		if (axisX > 0 && axisY > 0)
			istate = 3;
        else
        if(axisX<0 && axisY>0)
				istate=-3;
        else
        if(axisX>0 && axisY<0)
				istate=4;
        else
        if(axisX<0 && axisY<0)
				istate=-4;
        else
        if (axisY > 0)
				istate=1;
        else
        if (axisY < 0)
				istate=-1;
        else
        if (axisX > 0)
				istate=2;
        else
        if (axisX < 0)
				istate=-2;
        else
			istate=0;
		
		myAnim.SetInteger("state", istate);
		propRightAnim.SetInteger ("state", istate);
		propLeftAnim.SetInteger ("state", istate);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : Shot {


	public int ShotMode=1;

    [SerializeField]
    float delayst;
    [SerializeField]
    float delayss;
 


	// Use this for initialization
	void Start () {
        
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
		Shooting ();
	}

	public override void Shooting()
	{
		if (Input.GetKey (KeyCode.Space)) {
			

			if (typeShot == shots.single) {
                delay = delayst;
                myAnimator.SetBool("charge", true);
                SingleShot (0);
                
            }
            if (typeShot == shots.triple) {
                delay = delayst;
                myAnimator.SetBool("charge", true);
                TripleShot (10, 0, -10);
               
            }
            if (typeShot == shots.homming) {
                delay = delayss;
                SuperShotpt1();
                
            }

        } else

			if(Input.GetKeyUp(KeyCode.Space))
				myAnimator.SetBool ("charge", false);



	}


	public void setShot(int type)
	{
		if (type == 0)
			typeShot = shots.single;
        else
		if (type == 1)
			typeShot = shots.triple;
        else
		if (type == 2)
			typeShot = shots.homming;
        else
            typeShot = shots.nothing;



    }

	


}

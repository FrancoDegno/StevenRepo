using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : Shot {
	[SerializeField]
	float maxDelay;
	float rdm;



    public void SetShot(shots t)
    {
        typeShot = t;
    }



    public void setMinDelay(float d)
    {
       delay = d;

    }

    public void setMaxDelay(float d)
    {
        maxDelay = d;

    }

	public override void Shooting ()
	{
		if (typeShot == shots.single) {
			shoot = true;
			SingleShot (180);
		
		}

		if (typeShot == shots.triple) {
			shoot = true;
			TripleShot (170, 180, 190);

		}


	}
	// Use this for initialization
	public void playShot () {
		rdm = Random.Range (delay, maxDelay);
		StartCoroutine (callShot ());
	}
	
	IEnumerator callShot()
	{
		yield return new WaitForSeconds (rdm/MySingleClass.SpeedTimer);
		Shooting ();
		playShot ();

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StebonnieShot : Shot {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
		Shooting ();
	}

	public override void Shooting ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			SingleShot (4.5f);
		}
	}

    public override void SingleShot(float ang)
    {
        if (shoot)
        {
            shoot = false;
            lateTime = 0;
            GameObject auxBullet = ReturnBullet();
            if (auxBullet != null)
            {
                auxBullet.transform.position = CannonPos.position;
                auxBullet.SetActive(true);
                auxBullet.GetComponent<Bullet>().Ang = ang;

            }
        }
    }
}

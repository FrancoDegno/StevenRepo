using UnityEngine;
using System.Collections;

public class HomingBullet : Bullet
{
	[SerializeField]
	float timerUpdatePos;



	public	Transform target;
	float lateTime=0;
	float provAngle;

	void HomingShot()
	{

		
		//this.transform.Translate(new Vector3 (this.transform.position.x, target.position.y, this.transform.position.z));
		updatePosition();
	}

	void updatePosition()
	{
		if (Time.time > lateTime + timerUpdatePos) {
			lateTime = Time.time;
			provAngle = 180 / Mathf.PI * Mathf.Atan2 (target.position.y - transform.position.y, target.position.x - transform.position.x);
		}

		Ang = Mathf.LerpAngle(Ang,provAngle,Time.deltaTime*14);
		
	}

	public override void BulletMov ()
	{
		HomingShot();
		base.BulletMov ();
	}


	// Update is called once per frame
	void Update ()
	{
		BulletMov ();
	}
}


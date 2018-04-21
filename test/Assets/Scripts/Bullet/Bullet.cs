using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	
	[SerializeField]
	bool speedByTimer=false;
	public float speedBullet;
	public float Ang { get;set;}




	void AngShot(float speed)
	{
		float trueAngle = Ang * Mathf.PI / 180;
		transform.eulerAngles = new Vector3 (0, 0, Ang);
		if(speedByTimer)
			transform.position+= new Vector3(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime)*MySingleClass.SpeedTimer;
		else
			transform.position+= new Vector3(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime);

	}

	public virtual void BulletMov()
	{
		AngShot (speedBullet);
		}


    void Update()
    {
		BulletMov ();
		
    }


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == 10)
			this.gameObject.SetActive (false);

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 10)
            this.gameObject.SetActive(false);

    }




}

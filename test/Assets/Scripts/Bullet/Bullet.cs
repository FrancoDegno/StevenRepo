using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	
	[SerializeField]
	bool speedByTimer=false;
	public float speedBullet;
	public float Ang { get;set;}
    bool mov3d=false;



	void AngShot(float speed)
	{
		float trueAngle = Ang * Mathf.PI / 180;
		transform.eulerAngles = new Vector3 (0, 0, Ang);
		if(speedByTimer)
			transform.position+= new Vector3(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime)*MySingleClass.SpeedTimer;
		else
			transform.position+= new Vector3(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime);

	}

    public void activateMov3d()
    {
        mov3d = true;
    }

    public virtual void bullet3D()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedBullet);

    }

	public virtual void BulletMov()
	{
		AngShot (speedBullet);
		}


    void Update()
    {

		
        if(mov3d)
            bullet3D();
        else
            BulletMov();

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

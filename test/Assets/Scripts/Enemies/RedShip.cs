using UnityEngine;
using System.Collections;

public class RedShip : EnemyShip
{



	[SerializeField]
	string namePlayer;
	[SerializeField]
	float delay;
	[SerializeField]
	Transform target;
    [SerializeField]
    Transform newParent;

	float lateTime=0;
	float Angle=180;
	float provAngle = 180;


	// Use this for initialization

  
	void Start ()
	{
		SearchTarget ();
		lateTime = delay;
	}

    public void setName(string t)
    {
        namePlayer = t;
    }

    public void setDelay(float t)
    {
        delay = t;
    }

   
    void SearchTarget()
	{

		if (namePlayer == null)
			namePlayer = "player";

		if (GameObject.Find (namePlayer))
			target = GameObject.Find (namePlayer).transform;
		else
			Debug.LogError ("No se encuentra al player");
	
	}

	public override void MovShip (float speed)
	{
		
		if (target!=null && target.position.x < transform.position.x) {
			if (lateTime >= delay) {
				lateTime = 0;
				provAngle = 180 / Mathf.PI * Mathf.Atan2 (target.position.y - transform.position.y, target.position.x - transform.position.x);
			}
			Angle = Mathf.LerpAngle (Angle, provAngle, Time.deltaTime * 14);
			AngMov (speed, Angle);
		} else {
			AngMov (speed, 180);
		}

	}




	// Update is called once per frame
	void Update ()
	{
		
		lateTime += Time.deltaTime;
		if (mov) {
            if (transform.parent != null && transform.parent != newParent)
                transform.parent = newParent;
			MovShip (speed);
		}
	}
}


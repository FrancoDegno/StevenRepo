using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class EnemyShip : MonoBehaviour {

    [SerializeField]
    int layerOff;
    [SerializeField]
	public float speed;
    protected bool mov = true;
    protected ReciveDmg rcvdmg;
    protected ShieldShip shield;
    protected EnemyShot[] shots;

   protected void Start()
    {
        rcvdmg = this.GetComponent<ReciveDmg>();
        if (GetComponent<ShieldShip>())
            shield = GetComponent<ShieldShip>();
        if (GetComponent<EnemyShot>())
            shots = GetComponents<EnemyShot>();

    }
    public void startMov()
    {
        mov = true;
    }
    public void endMov()
    {
        mov = false;

    }
    public virtual void restart()
    {
        if (rcvdmg == null)
            Start();

        rcvdmg.restartHp();
        if (shield != null)
            shield.restart();
        if (shots!=null && shots.Length > 0)
            for (int i = 0; i < shots.Length; i++)
            {
                shots[i].playShot();
            }
    }


    public abstract void MovShip(float speed);





    public void AngMov(float speed,float Ang)
	{
		float trueAngle = Ang * Mathf.PI / 180;
		transform.eulerAngles = new Vector3 (0, 0, Ang);
		transform.position+= new Vector3(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime)*MySingleClass.SpeedTimer;

	}



    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == layerOff)
            this.gameObject.SetActive(false);
    }

}

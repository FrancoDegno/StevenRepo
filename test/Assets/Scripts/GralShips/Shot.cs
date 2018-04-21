using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Shot : MonoBehaviour {
 
	[SerializeField]
	protected Transform CannonPos;
	[SerializeField]
	Transform poolObject;
    [SerializeField]
    GameObject superShot;


	public enum shots{single,triple,homming,nothing};
	[SerializeField]
	protected shots typeShot;


	[SerializeField]
	protected Animator myAnimator;

    [SerializeField]
	protected float delay;

	protected bool shoot=false;
    protected float lateTime=0;


    [SerializeField]
    float lateTimess = 0;


	public abstract void Shooting ();

    protected void Start()
    {
        if(superShot)
            other = superShot.GetComponentInChildren<BoxCollider2D>();
       
    }

    public void setLateTime(float time)
    {
        lateTime = time;
    }

	protected void Update()
	{
	

		lateTime += Time.deltaTime;
        lateTimess += Time.deltaTime;
        if (lateTime >= delay && !shoot) {
			shoot = true;
			lateTime = 0;
		}
       
	}

    public virtual void HommingShot(Transform target)
	{
		if (shoot) {
			shoot = false;
			lateTime = 0;
			GameObject auxBullet = ReturnBullet();
			auxBullet.GetComponent<HomingBullet> ().target = target;
		}
	
	}

	public virtual void SingleShot(float ang)
	{	if (shoot) {
			shoot = false;
			lateTime = 0;
       		GameObject auxBullet = ReturnBullet();
			if (auxBullet != null) {
				auxBullet.transform.position = CannonPos.position;
				auxBullet.SetActive (true);
				auxBullet.GetComponent<Bullet> ().Ang = ang;

			}
		}
	}




    //------------------------SUPERSHOT -----------------------------//
    Collider2D other;
    public virtual void SuperShotpt1()
    {
        if(superShot && lateTimess>delay)
        {
            
            lateTimess = 0;
            print(lateTimess);
            superShot.GetComponent<Animator>().SetBool("active", true);
            SuperShotpt2();
        }
    }

    protected virtual void SuperShotpt2()
    {
        other.enabled = true;
        StartCoroutine(InvokeSuper());
    }

    IEnumerator InvokeSuper()
    {
        yield return new WaitForSeconds(1.5f);
        other.enabled = false;
        superShot.GetComponent<Animator>().SetBool("active", false);
    }

    //----------------------FINISH SUPERSHOT ------------------------//

    protected virtual void TripleShot(float ang1,float ang2,float ang3)
    {
		if (shoot) {
			shoot = false;
			lateTime = 0;
			float[] angles = new float[3]{ ang3, ang2, ang1 };
			GameObject auxBullet;
			for (int i = 0; i < 3; i++) {
				auxBullet = ReturnBullet ();
				if (auxBullet != null) {
					auxBullet.transform.position = CannonPos.position;
					auxBullet.SetActive (true);
					Bullet AUX = auxBullet.GetComponent<Bullet> ();
					AUX.Ang = angles [i];
				}
			}
		}

	
    }



    //-------------OBTENER BALA DESACTIVADA --------------

    protected GameObject ReturnBullet()
    {
        for (int i = 0; i < poolObject.childCount; i++)
        {
            if (!poolObject.GetChild(i).gameObject.activeInHierarchy)
                return poolObject.GetChild(i).gameObject;
        }

        return null;
    }



}

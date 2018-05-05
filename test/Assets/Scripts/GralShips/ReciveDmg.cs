using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciveDmg : MonoBehaviour {

    // Use this for initialization

   
    [SerializeField]
    protected Animator Anim;
    [SerializeField]
    GameObject explotion;
    public int Hp;
	[SerializeField]
	bool DesactiveInDead;
    [Header("Hp damageded")]
	[SerializeField]
	public float realHp;
    [SerializeField]
    bool restOnEnable = true;


	void Start()
	{
		restartHp ();

	}

    void OnEnable()
    {
        if(restOnEnable)
            restartHp();
    }

    public void restartHp()
	{
		realHp = Hp;

	}


	public bool reciveDamage(float dmg)
    {
		realHp-= dmg;
        if (realHp < 0)
            realHp = 0;

		if (realHp <= 0) {
			death ();
			return true;
		} else {
			ReciveHit ();
			return false;
		}

    }


    void ReciveHit()
    {
		if (Anim != null) {
			Anim.SetBool ("Hit", true);
			StartCoroutine ("offAnim");
		}
    }

    IEnumerator offAnim()
    {
        yield return new WaitForEndOfFrame();
       Anim.SetBool("Hit", false);

    }

    public virtual void death()
    {

		if (!DesactiveInDead)
			Destroy (this.gameObject);
		else {
			gameObject.SetActive (false);
			MySingleClass.NumberShipDeads++;
		}
        Instantiate(explotion, this.transform.position, this.transform.rotation);
    }



}

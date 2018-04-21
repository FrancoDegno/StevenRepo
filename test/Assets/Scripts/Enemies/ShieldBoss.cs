using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBoss : MonoBehaviour {
	[SerializeField]
	Animator myAnim;


	void OffAnim()
	{
		myAnim.SetBool ("Shield", false);
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 13)
		{
            other.gameObject.SetActive(false);
			myAnim.SetBool ("Shield", true);
			Invoke ("OffAnim", 0.1f);
		}
	
	}

}

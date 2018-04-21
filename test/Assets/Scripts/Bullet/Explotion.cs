using UnityEngine;
using System.Collections;

public class Explotion : MonoBehaviour
{

	[SerializeField]
	float timer_desactive;

	public float speed {
		get;
		set;
	}

	void mov()
	{
		this.transform.position += new Vector3 (speed * Time.deltaTime * MySingleClass.SpeedTimer, 0, 0);

	}
	void call_desactivate()
	{
		gameObject.SetActive (false);
	}


	public void desactive()
	{
		Invoke ("call_desactivate", timer_desactive);

	}


	// Update is called once per frame
	void Update ()
	{
	
		mov ();

	}
}


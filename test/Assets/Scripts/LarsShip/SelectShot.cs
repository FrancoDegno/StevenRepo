using UnityEngine;
using System.Collections;

public class SelectShot : MonoBehaviour
{
	[SerializeField]
	Animator wheel;

	[SerializeField]
	bool triple=false;
	[SerializeField]
	bool homing=false;

	[SerializeField]
	int selected=0;


	// Use this for initialization
	void Start ()
	{
	
	}



	void changeSelected()
	{

		selected += 1;
        
		

		if ((selected == 1 || selected == 4) && !homing)
			selected += 1;

		if ((selected == 2 || selected == 5) && !triple)
			selected += 1;
			
		if (selected == 6)
			selected = 0;
		else if (selected > 6) {
			int sobra = 6 - selected;
			selected = 0 + sobra;
		}

		setTypeShot ();


	}

	void setTypeShot()
	{

		PlayerShot[] Cannons = GetComponents<PlayerShot> ();

		if (selected == 3 || selected == 0) {
            Cannons[0].setLateTime(1);
            Cannons[1].setLateTime(1);

            Cannons[0].setShot (0);
			Cannons[1].setShot (0);
		}
		if (selected == 2 || selected == 5) {
            Cannons[0].setShot(2);
            Cannons[1].setShot(2);

        }


		if(selected==1 || selected == 4) {
            Cannons[0].setShot(3);
            Cannons[1].setShot(1);
         

        }
    }
		
		


	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKeyDown (KeyCode.H)) {
            changeSelected();
            wheel.SetInteger("shotType", selected);


        }

        if (homing && !wheel.GetBool("s1"))
            wheel.SetBool("s1", true);
        if (triple && !wheel.GetBool("s2"))
            wheel.SetBool("s2", true);



    }
}


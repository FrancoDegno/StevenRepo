using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMov : MonoBehaviour {



   
	[SerializeField]
	int layerStop;

    public float velX=0;
    public float velY = 0;
    public int stop = 1;
    public int stopf = 1;

   float axisX, axisY;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
        mov();       
	
	}



    void mov()
    {
		axisX = Input.GetAxis("Horizontal");
		axisY = Input.GetAxis("Vertical");
      
		      
		if (axisX == 0)
			stop = 1;

		if (axisX<0)
        {
            //this.transform.localPosition -= new Vector3(Time.deltaTime * velX, 0);
			transform.Translate(new Vector3(Time.deltaTime *-1* velX*stop, 0));
        }

        if (axisX > 0)
        {
            //this.transform.position += new Vector3(Time.deltaTime *stop* velX, 0);
            transform.Translate(new Vector3(Time.deltaTime * velX * stopf, 0));
        }
     

		if (axisY>0)
        {
            this.transform.position += new Vector3(0, Time.deltaTime*velY);
        }

        if (axisY<0)
        {
            this.transform.position -= new Vector3(0, Time.deltaTime * velY);
        }


    }


	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.layer == layerStop) {
			stop = 0;


		}

	}


	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.layer == layerStop)
        {
            stop = 1;
        }
			

	}



}

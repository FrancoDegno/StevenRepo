using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMov : MonoBehaviour {



   
	[SerializeField]
	int layerStoph;
    [SerializeField]
    int layerStopv;

    public float velX=0;
    public float velY = 0;
    public int stopf = 1;
    public int stoph = 1;
    public int stopv = 1;

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
            stoph = 1;
        if (axisY == 0)
            stopv = 1;

        if (axisX<0)
        {
            //this.transform.localPosition -= new Vector3(Time.deltaTime * velX, 0);
            transform.Translate(new Vector3(Time.deltaTime * -1 * velX * stoph, 0));
        }

        if (axisX > 0)
        {
            //this.transform.position += new Vector3(Time.deltaTime *stop* velX, 0);
            transform.Translate(new Vector3(Time.deltaTime * velX * stopf, 0));
        }
     

		if (axisY>0)
        {
            this.transform.position += new Vector3(0, Time.deltaTime * velY * stopv);
        }

        if (axisY<0)
        {
            this.transform.position -= new Vector3(0, Time.deltaTime * velY * stopv);
        }


    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == layerStoph)
        {
           
            stoph = 0;

        }

        if (other.gameObject.layer == layerStopv)
        {

            stopv= 0;

        }

    }


	void OnTriggerExit2D(Collider2D other)
	{
        if (other.gameObject.layer == layerStoph)
        {

            stoph = 1;

        }

        if (other.gameObject.layer == layerStopv)
        {

            stopv = 1;

        }


    }



}

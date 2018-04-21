using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBullet : MonoBehaviour {

    [SerializeField]
    int layerTarget;
    [SerializeField]
	Transform exploBullet;
    [SerializeField]
    float BulletDmg;
    [SerializeField]
    float sizeImpactExplo;
    [SerializeField]
    float sizeDeathExplo;

    // Use this for initialization

    void Start () {
        if(exploBullet==null)
		    exploBullet = GameObject.Find ("ExploPool").transform;
	}


    public void setDmg(float d)
    {
        BulletDmg = d;
    }

    public void setImpactExplo(float s)
    {
        sizeImpactExplo = s;
    }
    public void setSizeDeathExplo(float s)
    {
        sizeDeathExplo = s;
    }


	void resizeObject(float size,Transform obj)
	{
		obj.localScale = new Vector3 (size, size, size);

	}

	
	Transform genExplotion()
	{
		if (exploBullet != null) {
			for (int i = 0; i < exploBullet.childCount; i++) {
				if (!exploBullet.GetChild (i).gameObject.activeInHierarchy) {
					return exploBullet.GetChild (i);

				}

			}
		}
		return null;
	}



	void createExplotion(GameObject other)
	{
		Transform explotion = genExplotion ();
        Vector3 position = Vector3.zero;

        if (explotion != null) {
			float size = sizeImpactExplo;
            position = transform.position;

			//si el objeto al que se le hace daño es destruido retornara true
		if (other.GetComponent<ReciveDmg> ().reciveDamage(BulletDmg)) { 
			size = sizeDeathExplo;
                position = other.transform.position;
            }

            resizeObject (size, explotion);
		explotion.gameObject.SetActive (true);
		explotion.GetComponent<Explotion> ().speed = 0;
        explotion.position = position;
		if (other.gameObject.GetComponent<EnemyShip> ())
			explotion.GetComponent<Explotion> ().speed = other.gameObject.GetComponent<EnemyShip> ().speed * -1;
			
		explotion.GetComponent<Explotion> ().desactive ();

		}
	
	}


    void OnTriggerEnter2D(Collider2D other)
    {

		if (other.gameObject.layer == layerTarget)
        {
			createExplotion (other.gameObject);
			gameObject.SetActive (false);
        }

    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == layerTarget)
		{
            createExplotion(other.gameObject);
        }

	}





}

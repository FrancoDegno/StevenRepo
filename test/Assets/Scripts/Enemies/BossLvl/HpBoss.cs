using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBoss : MonoBehaviour {
    [SerializeField]
    bool dead = false;
    [SerializeField]
    GameObject[] Parts = new GameObject[4];


	// Use this for initialization
	void Start () {
		
	}
	

    int cantLifes()
    {
 
        List<GameObject> l1 = new List<GameObject>();
        for (int i = 0; i < Parts.Length; i++)
            if (Parts[i].activeInHierarchy)
                l1.Add(Parts[i]);

        return l1.Count;
    }

	// Update is called once per frame
	void Update () {
		if(cantLifes()==0 && !dead)
        {
            dead = true;
            MySingleClass.fGame = true;
        }
	}
}

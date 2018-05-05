using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour {
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject[] victory= new GameObject[1];



	
	// Update is called once per frame
	void Update () {
        if (MySingleClass.fGame && player)
        { 
            for(int i=0;i<victory.Length;i++)
            {
                victory[i].SetActive(true);
            }
         
            Destroy(this);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStebonnie : MonoBehaviour {
    [SerializeField]
    GameObject bship;
    [SerializeField]
    Vector3 startPosition;
    [SerializeField]
    Transform movObject;
    [SerializeField]
    GameObject normalPlayer;
    [SerializeField]
    GameObject backPlayer;
    [SerializeField]
    int layer;
    bool rest;
    float initialSpeed;
    
	// Use this for initialization
	void Start () {
        initialSpeed = movObject.root.GetComponent<Parallax>().speed;

    }
	


    void restart()
    {

        if (rest) {
            movObject.transform.position = Vector3.Lerp(movObject.transform.position,startPosition, Time.deltaTime * 0.5f);
            if (Vector3.Distance(movObject.transform.position, startPosition) < 5)
            {
                activeObjects();
               
            }
             }

    }

    void activeObjects()
    {
        movObject.GetComponent<CharacterMov>().enabled = true;
        movObject.root.GetComponent<Parallax>().speed = initialSpeed;
        rest = false;
        normalPlayer.SetActive(true);
        backPlayer.SetActive(false);
        bship.GetComponent<BossShip>().enabled = true;
        normalPlayer.GetComponent<AnimStebonnie>().enabled = true;
        normalPlayer.GetComponent<Animator>().enabled = true;
    }


    IEnumerator desactiveObjects()
    {


        normalPlayer.GetComponent<AnimStebonnie>().setOff();
        yield return new WaitForSeconds(0.3f);
        normalPlayer.SetActive(false);
        backPlayer.SetActive(true);
      
        rest = true;
        movObject.GetComponent<CharacterMov>().enabled = false;
        movObject.root.GetComponent<Parallax>().speed = 0;
        bship.GetComponent<BossShip>().enabled = false;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==layer)
        {
            StartCoroutine(desactiveObjects());
        }
    }

    void Update()
    {
        restart();
    }

}

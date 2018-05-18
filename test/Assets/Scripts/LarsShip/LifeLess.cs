using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeLess : MonoBehaviour {
    [SerializeField]
    GameObject fadeIn;
    [SerializeField]
    ReciveDmg playerDmg;
    Animator lifes;
    [SerializeField]
    float divideBy = 50;
    bool dead = false;
	// Use this for initialization
	void Start () {
        lifes = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (playerDmg && !dead) { 
            lifes.SetInteger("state", (int)(playerDmg.realHp / divideBy));

            if(lifes.GetInteger("state")==0)
            {
                dead = true;
                lifes.SetInteger("state", 0);
                print("Restart");
                StartCoroutine(restartLvl());
            }
        }
        else
        {
            if (!dead) {
                dead = true;
                lifes.SetInteger("state", 0);
                print("Restart");
                StartCoroutine(restartLvl());
            }
        }


    }

    IEnumerator restartLvl()
    {
        if (fadeIn != null) { 
            yield return new WaitForSeconds(2.5f);
            fadeIn.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        { 
                yield return new WaitForSeconds(2.5f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}

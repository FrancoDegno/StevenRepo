using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class CreateEnemies : MonoBehaviour {

    [SerializeField]
    float startTime = 0;
	[SerializeField]
	Transform[] parentsPools= new Transform[4];

	[SerializeField]
	float MaxDelayShip=5f;
	[SerializeField]
	float MinDelayShip=0.5f;
	float randomDelay=0;

	[Header("Wave Mode")]
	[SerializeField]
	int changeby_enemieDeads;
	[SerializeField]
	float changeby_LapTime;
    int lastPoolsCant;


	int number_wave=0;
	//int number_deaths=0;


	void Start()
	{
        lastPoolsCant = parentsPools[parentsPools.Length - 1].childCount;
        StartCoroutine(delayCreator());
	}

    void Update()
    {
        print(number_wave);
    }

    IEnumerator delayCreator()
    {
        yield return new WaitForSeconds(startTime);
        StartCreator();
        yield return new WaitForSeconds(changeby_LapTime);
        number_wave++;
        yield return new WaitForSeconds(changeby_LapTime);
        number_wave++;
        yield return new WaitForSeconds(changeby_LapTime);
        number_wave++;
        yield return new WaitForSeconds(changeby_LapTime);
        number_wave++;
        StartCoroutine(FinishWaves());
    }

    IEnumerator FinishWaves()
    {
        yield return new WaitForSeconds(5);
       
        if (number_wave >= parentsPools.Length)
        {
            int count = 0;
            for (int i = 0; i < parentsPools[parentsPools.Length - 1].childCount; i++)
            {
                if (!parentsPools[parentsPools.Length - 1].GetChild(i).gameObject.activeInHierarchy)
                    count++;
            }
            if (lastPoolsCant == count)
                MySingleClass.fGame = true;
            else
                StartCoroutine(FinishWaves());
        }
        else
            StartCoroutine(FinishWaves());
        
    }


	GameObject selectDesactiveShip()
	{
        if (number_wave >= parentsPools.Length)
            return null;

		for (int i = 0; i < parentsPools [number_wave].childCount; i++) {
			if (!parentsPools [number_wave].GetChild (i).gameObject.activeInHierarchy) {
				return parentsPools [number_wave].GetChild (i).gameObject;
				
				}
		
		}
		return null;


	}


    void StartCreator()
    {
        randomDelay = Random.Range(MinDelayShip, MaxDelayShip);
        StartCoroutine(activeShip());

    }

	IEnumerator activeShip()
	{
		yield return new WaitForSeconds (randomDelay/MySingleClass.SpeedTimer);
		GameObject ship = selectDesactiveShip ();
		if (ship != null) {
            ship.transform.position = transform.position;
            ship.SetActive(true);
            yield return new WaitForEndOfFrame();
            ship.GetComponent<EnemyShip>().restart();
            
        }
        StartCreator();


	}

}






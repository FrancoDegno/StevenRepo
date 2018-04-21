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


	int number_wave=0;
	//int number_deaths=0;


	void Start()
	{
        StartCoroutine(delayCreator());
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

    }

	GameObject selectDesactiveShip()
	{
		
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






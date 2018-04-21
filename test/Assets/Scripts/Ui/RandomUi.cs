using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomUi : MonoBehaviour {

	[SerializeField]
	Transform ObjectsActivate;


	float countAct=0;
	float countDes=0;
	float rdmTimeA=0;
	float rdmTimeD=0;

	Image[] MyImages;


	void Start()
	{
		MyImages = new Image[ObjectsActivate.childCount];

		for (int i = 0; i < MyImages.Length; i++) {
			MyImages [i] = ObjectsActivate.GetChild (i).GetComponent<Image>();
		}
	}

	void Update () {

		if (rdmTimeA == 0)
			rdmTimeA = Random.Range (0.1f, 0.5f);
		else {
			countAct += Time.deltaTime;

			if (countAct >= rdmTimeA)
				selectToActivate (Random.Range (0, MyImages.Length));
		}

		if(rdmTimeD==0)
			rdmTimeD = Random.Range (0.1f, 1);
		else {
			countDes += Time.deltaTime;

			if (countDes >= rdmTimeD)
				selectToDesactive (Random.Range (0, MyImages.Length));
		}


	}


	void selectToActivate(int item)
	{
		MyImages [item].enabled = true;
		rdmTimeA = 0;
		countAct = 0;

	}


	void selectToDesactive(int item)
	{
		MyImages [item].enabled = false;
		rdmTimeD = 0;
		countDes = 0;

	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeUiCollider : MonoBehaviour {
	[SerializeField]
	Image imageToFade;
	[SerializeField]
	Color color1;
	[SerializeField]
	Color color2;
	// Use this for initialization
	bool fade=false;
	Image[] images;


	void Start()
	{
		images = new Image[imageToFade.transform.childCount+1];
		images [0] = imageToFade;
		for (int i = 1; i < images.Length; i++) {
			images [i] = imageToFade.transform.GetChild (i-1).GetComponent<Image>();
		}

	}

	// Update is called once per frame
	void Update () {
		if (fade) {
			for (int i = 0; i < images.Length; i++) {
				images [i].color = Color.Lerp (images [i].color, color2, Time.deltaTime * 14);
			}
		
		} else
			for (int i = 0; i < images.Length; i++) {
				images [i].color = Color.Lerp (images [i].color, color1, Time.deltaTime * 14);
			}


	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == 11)
		{
			fade = true;
		
		}


	}


	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.layer == 11)
		{
			fade = false;


		}

	}


}

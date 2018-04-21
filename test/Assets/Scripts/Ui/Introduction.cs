using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour {
    [SerializeField]
    GameObject aux;
    bool block = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.anyKeyDown && !block)
        {
            block = true;
            aux.SetActive(true);
            Invoke("changeScene", 1f);
        }

	}
    void changeScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

}

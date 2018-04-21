using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {


	public void playGame()
	{
		SceneManager.LoadScene ("Main");
	}

    public void menuScene()
    {
        SceneManager.LoadScene("MenuScene");

    }

}

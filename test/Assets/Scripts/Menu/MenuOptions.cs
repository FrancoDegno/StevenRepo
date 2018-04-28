using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {
    [SerializeField]
    GameObject FadeOut;



	public void playGame()
	{
        FadeOut.SetActive(true);
        StartCoroutine(changeScene("LarsMision"));
    }

    public void menuScene()
    {
        FadeOut.SetActive(true);
        StartCoroutine(changeScene("MenuScene"));

    }

    IEnumerator changeScene(string scene)
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(scene);

    }

}

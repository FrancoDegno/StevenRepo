using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {
    [SerializeField]
    GameObject FadeOut;



    public void change(string nameScene)
    {
        FadeOut.SetActive(true);
        StartCoroutine(changeScene(nameScene));
    }

    IEnumerator changeScene(string scene)
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(scene);

    }

}

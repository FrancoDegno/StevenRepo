using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnStart : MonoBehaviour {

    [SerializeField]
    string nameScene;
    [SerializeField]
    float time;

	// Use this for initialization
	void Start () {
        StartCoroutine(change());
	}
	
    IEnumerator change()
    {
        yield return new WaitForSeconds(time);
        print("CHANGE SCENEEE");
        SceneManager.LoadScene(nameScene);
    }
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndFollow : MonoBehaviour {
    [SerializeField]
    Transform target;
    [SerializeField]
    float speed;
    [SerializeField]
    float refreshFollow;

    [SerializeField]
    bool flagStop = false;

	// Update is called once per frame
    void Start()
    {

        
        if (Vector3.Distance(transform.position, target.position) <30)
            flagStop = true;

        if(!flagStop)
            StartCoroutine(follow());

    }


    IEnumerator follow()
    {
        yield return new WaitForSeconds(refreshFollow);
       
        transform.LookAt(target.position);
        Start();
    }

	void Update () {
        
        transform.Translate( Vector3.forward*Time.deltaTime * speed);

	}
}

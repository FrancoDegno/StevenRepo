using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {
    [SerializeField]
    Transform target;
    [SerializeField]
    float refreshFollow=0;
    [SerializeField]
    bool ejex=true;
    [SerializeField]
    bool ejey = true;
    [SerializeField]
    bool ejez = true;

    Vector3 followVector;
	// Use this for initialization
	void Start () {
        restartPosition();
	}

    public void restartPosition()
    {
        transform.position = target.position;
        followVector = target.position;
        startcoroutine();
    }

    void startcoroutine()
    {
        StartCoroutine(follow());
        
    }

    void OnEnable()
    {
        restartPosition();
    }
	
    IEnumerator follow()
    {
        yield return new WaitForSeconds(refreshFollow);


        if (ejex && ejey && ejez)
            followVector = target.position;
        else
        if (ejex && ejey && !ejez)
            followVector = new Vector3(target.position.x, target.position.y, transform.position.z);
        else
        if(ejex && !ejey && ejez)
            followVector = new Vector3(target.position.x, transform.position.y,target.position.z);
        else
        if (!ejex && ejey && ejez)
            followVector = new Vector3(transform.localPosition.x, target.position.y, target.position.z);

        startcoroutine();

    }

    void FixedUpdate()
    {

        if (!ejex && ejey && ejez)
            followVector.x = target.position.x;

            transform.position = Vector3.Lerp(transform.position, followVector, Time.deltaTime*0.5f);

    }


}

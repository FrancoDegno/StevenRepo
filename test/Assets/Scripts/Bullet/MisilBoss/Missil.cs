using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : Bullet {

    [SerializeField]
    Transform target;
    [SerializeField]
    float refreshFollow;

    [SerializeField]
    bool flagStop = false;

    // Update is called once per frame
    void Start()
    {

        activateMov3d();
        if (Vector3.Distance(transform.position, target.position) < 30)
            flagStop = true;

        if (!flagStop)
            StartCoroutine(follow());

    }


    IEnumerator follow()
    {
        yield return new WaitForSeconds(refreshFollow);

        transform.LookAt(target.position);
        Start();
    }

   
}

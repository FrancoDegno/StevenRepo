using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : Bullet {

    [SerializeField]
    Transform target;
    [SerializeField]
    float refreshFollow;
    int stopMisil = 1;
    [SerializeField]
    bool flagStop = false;
    Vector3 initPos;
    Vector3 initRot;

    // Update is called once per frame
    void Awake()
    {
        initRot = transform.eulerAngles;
        initPos = transform.localPosition;
    }

    void Start()
    {

        GetComponent<Rigidbody>().isKinematic = false;
        activateMov3d();
        if (Vector3.Distance(transform.position, target.position) < 30)
            flagStop = true;

        if (!flagStop)
            StartCoroutine(follow());

    }

    public override void bullet3D()
    {
        
            transform.Translate(Vector3.forward * Time.deltaTime * speedBullet*stopMisil);

        
    }

    void pause()
    {
        stopMisil = 0;
    }

    void unPause()
    {
        stopMisil = 1;
    }

    void OnEnable()
    {

        MissilAttack.misilPause += pause;
        MissilAttack.misilUnPause += unPause;
        flagStop = false;
        transform.eulerAngles = initRot;
        transform.localPosition = initPos;

        Start();
    }

    void OnDisable()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        MissilAttack.misilPause -= pause;
        MissilAttack.misilUnPause -= unPause;
    }

    void OnDestroy()
    {
        MissilAttack.misilPause -= pause;
        MissilAttack.misilUnPause -= unPause;
    }

    IEnumerator follow()
    {
        yield return new WaitForSeconds(refreshFollow);
        transform.LookAt(target.position);
        Start();
    }

  
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShip :EnemyShip {

    [SerializeField]
    Vector3[] PositionsScene = new Vector3[4];
    int ActualPosition=0;
    public override void MovShip(float speed)
    {
        this.transform.position = Vector3.Lerp(transform.position, PositionsScene[ActualPosition], Time.deltaTime * speed);
    }
    public override void restart()
    {
        throw new System.NotImplementedException();
    }

    void changeTarget()
    {

    }
	
	// Update is called once per frame
	void Update () {
        MovShip(speed);
	}
}

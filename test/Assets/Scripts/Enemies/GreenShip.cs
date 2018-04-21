using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShip : EnemyShip {
   

    public override void MovShip(float speed)
    {
		AngMov (speed, -180);
        //this.transform.position -= new Vector3(speed * Time.deltaTime, 0);
    }

    // Use this for initialization
  
    public override void restart()
    {
        base.restart();
    }
	
	// Update is called once per frame
	void Update () {
        if(mov)
            MovShip(speed);
	}
}

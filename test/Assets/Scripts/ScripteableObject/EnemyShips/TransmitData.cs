using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitData : MonoBehaviour {

    [SerializeField]
    GreenData gData;
    GreenShip gship;
    ReciveDmg dmg;
    EnemyShot eshot;
    HitBullet hbullet;
  

	// Use this for initialization
	void Awake () {
        gship = GetComponent<GreenShip>();
        dmg = GetComponent<ReciveDmg>();
        eshot = GetComponent<EnemyShot>();
        hbullet = GetComponent<HitBullet>();
        gship.speed = gData.getSpeed();

        if(GetComponent<EnemyShot>())
        {
            eshot.SetShot((Shot.shots)gData.tShot);
            eshot.setMaxDelay(gData.getMaxd());
            eshot.setMinDelay(gData.getMind());
        }


        dmg.Hp = gData.getHp();
        hbullet.setDmg(gData.getimpDmg());
        hbullet.setImpactExplo(gData.getMinSizeExp());
        hbullet.setSizeDeathExplo(gData.getMaxSizeExp());

	}
	
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmtRData : MonoBehaviour {

    [SerializeField]
    RedData gData;
    RedShip gship;
    ReciveDmg dmg;
    EnemyShot eshot;
    HitBullet hbullet;


    // Use this for initialization
    void Awake()
    {
        gship = GetComponent<RedShip>();
        dmg = GetComponent<ReciveDmg>();
        hbullet = GetComponent<HitBullet>();


        gship.speed = gData.getSpeed();
        gship.setDelay(gData.getDelay());
        gship.setName(gData.getTarget());
        dmg.Hp = gData.getHp();
        hbullet.setDmg(gData.getimpDmg());
        hbullet.setImpactExplo(gData.getMinSizeExp());
        hbullet.setSizeDeathExplo(gData.getMaxSizeExp());

    }
}

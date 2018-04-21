using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldShip : MonoBehaviour {
    [Header("Shield cant")]
    [SerializeField]
    int shieldTotalHp;
    [SerializeField]
    int shieldHp = 0;
    [Header("image shield")]
    [SerializeField]
    SpriteRenderer shield;
    float hpaux;

    ReciveDmg dmgrecived;
    Collider2D circle;
    bool resthp = false;
   

	// Update is called once per frame

    void Start()
    {
 
        restart();
    }

    public void restart()
    {
        if (shield != null)
            shield.enabled = true;
  
        circle = this.GetComponent<CircleCollider2D>();
        if(circle==null)
            circle = this.GetComponent<CapsuleCollider2D>();
        circle.enabled = true;

        dmgrecived = this.GetComponent<ReciveDmg>();
        if (!resthp)
        {
            resthp = true;
            dmgrecived.Hp += shieldTotalHp;
            dmgrecived.restartHp();
        } 
        shieldHp = shieldTotalHp;
        hpaux = dmgrecived.Hp;


        //activar collider, activar sprite, asignar recivedmg, 


    }


	void Update () {
        if (shieldHp > 0 && dmgrecived.realHp!=hpaux)
        {
            hpaux = dmgrecived.realHp;
            shieldHp = shieldTotalHp;
            shieldHp -= (int)(dmgrecived.Hp - hpaux);
           

        }
        else
            if (shield != null && shieldHp <= 0) {
                shield.enabled = false;
                if (circle != null)
                     circle.enabled = false;
            }

    }
}

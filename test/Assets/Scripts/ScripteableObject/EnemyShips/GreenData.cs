using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="PeridotShip",menuName ="Enemy/Create Peridot Ship")]
public class GreenData : ScriptableObject {

    [Header("ATRIBUTOS NAVE")]
    [SerializeField]
    float Speed;
    [SerializeField]
    int Hp;


    public
    enum shots
    {
        single, triple, homming, nothing
    }
    [Header("DISPAROS")]
    [Header("tipo de disparo")]
    public shots tShot;
    [Header("delay min")]
    [SerializeField]
    float mind;
    [Header("delay max")]
    [SerializeField]
    float maxd;


    [Header("SI LA NAVE CHOCA")]
    [Header("Daño si la nave choca")]
    [SerializeField]
    float ShipImpactDmg;
    [Header("Si el objetivo no muere")]
    [SerializeField]
    float sizeExplo;
    [Header("Si el objetivo muere")]
    [SerializeField]
    float sizeMaxExplo;


    public float getSpeed()
    {
        return Speed;
    }

    public int getHp()
    {
        return Hp;
    }


    public float getMind()
    {
        return mind;
    }

    public float getMaxd()
    {
        return maxd;
    }

    public float getimpDmg()
    {
        return ShipImpactDmg;
    }

    public float getMinSizeExp()
    {
        return sizeExplo;
    }

    public float getMaxSizeExp()
    {
        return sizeMaxExplo;
    }
}

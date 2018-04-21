using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="Red Ship",menuName ="Enemy/Create Red Ship")]
public class RedData : ScriptableObject {

    [Header("ATRIBUTOS NAVE")]
    [SerializeField]
    float Speed;
    [SerializeField]
    int Hp;

    [Header("Target player name")]
    [SerializeField]
    string nameT;

    [Header("Delay Refresh Target Position")]
    [SerializeField]
    float delay;


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
    public string getTarget()
    {
        return nameT;
    }

    public float getDelay()
    {
        return delay;
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

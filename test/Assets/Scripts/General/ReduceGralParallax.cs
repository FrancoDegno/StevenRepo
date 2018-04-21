using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceGralParallax : MonoBehaviour {


    [SerializeField]
    float SpeedFloat;
    [SerializeField]
    Parallax[] MyChildrens;


    void Start()
    {
        MyChildrens = new Parallax[transform.childCount];

        for (int i=0;i<transform.childCount;i++)
        {
            MyChildrens[i] = transform.GetChild(i).GetComponent<Parallax>();
        }

        UpdateParallax();

    }


    public void UpdateParallax()
    {
        for(int i=0;i<MyChildrens.Length;i++)
        {
            if(MyChildrens[i]!=null)
            MyChildrens[i].speed = MyChildrens[i].speed / SpeedFloat;

        }


    }

}

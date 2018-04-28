using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningShip : MonoBehaviour {
    [SerializeField]
    Transform Misils;
    [SerializeField]
    GameObject alert;
    public static bool start;

	


   
   public void alertSignal()
    {
        List<int> Li = new List<int>();
        for(int i=0;i<Misils.childCount;i++)
        {
            if (Misils.GetChild(i).gameObject.activeInHierarchy)
                Li.Add(0);
        }
        if (Li.Count > 0)
            StartCoroutine(activeAlert());
    }

    IEnumerator activeAlert()
    {
        yield return new WaitForSeconds(0.5f);
        alert.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        alert.SetActive(false);

        alertSignal();

    }

    void Update()
    {
        if(start)
        {
            alertSignal();
            start = false;
        }

    }

}

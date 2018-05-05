using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleClass : MonoBehaviour {
	
	public static int NumberShipDeads=0;
	public static float SpeedTimer = 1;
	public static bool sound=true;
    public static bool fGame = false;

    public static void restSingle()
    {
        NumberShipDeads = 0;
        SpeedTimer = 1;
        fGame = false;
}

}

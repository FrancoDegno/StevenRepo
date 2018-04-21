using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.LarsShip
{


    class ScaleTimeSpeed: MonoBehaviour
    {
        [SerializeField]
        CharacterMov movPlayer;
       

        void Update()
        {
          
        	if (movPlayer.stop == 0) {
				if (MySingleClass.SpeedTimer <= 3) {
					MySingleClass.SpeedTimer += Time.deltaTime* 0.1f;
			}
} else 
		{
				if (MySingleClass.SpeedTimer >= 1) {
					MySingleClass.SpeedTimer -= Time.deltaTime*0.2f;
			
		}
		}

        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.layer == 12)
            {
                movPlayer.stop = 0;
            }

        }

        void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.layer == 12)
            {
                movPlayer.stop = 1;

            }

        }

    }
}

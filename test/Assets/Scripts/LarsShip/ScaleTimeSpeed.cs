using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.LarsShip
{


    class ScaleTimeSpeed: MonoBehaviour
    {
        [SerializeField]
        CharacterMov movPlayer;
       


        void FixedUpdate()
        {

            if (movPlayer.stoph == 0)
            {
                if (MySingleClass.SpeedTimer <= 3) {
					MySingleClass.SpeedTimer += Time.deltaTime* 0.1f;
			    }
            }
            else 
		    {
				if (MySingleClass.SpeedTimer >= 1) {
					MySingleClass.SpeedTimer -= Time.deltaTime*0.2f;
			
		        }
		    }

        }

        void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.layer == 12)
            {
                movPlayer.stopf = 0;
            }

        }

        void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.layer == 12)
            {
                movPlayer.stopf = 1;

            }

        }

    }
}

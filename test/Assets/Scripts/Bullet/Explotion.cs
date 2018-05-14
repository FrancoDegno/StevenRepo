using UnityEngine;
using System.Collections;

public class Explotion : MonoBehaviour
{

	[SerializeField]
	float timer_desactive;
    AudioSource audio;
    AudioClip explo;
    bool reciveVolume = false;

    void Awake()
    {

        audio = gameObject.AddComponent<AudioSource>() as AudioSource;
    }

    public void getAudio(AudioClip au)
    {
        explo = au;
    }

    public void reciveV(bool reciv)
    {
        reciveVolume = reciv;
    }

    void OnEnable()
    {

        if (audio != null)
        {
            if (!reciveVolume)
            {
               
                float size = transform.localScale.x;
                audio.volume = 1.5f * size;
            }
            audio.PlayOneShot(explo);
        }
     }
    



	public float speed {
		get;
		set;
	}

	void mov()
	{
		this.transform.position += new Vector3 (speed * Time.deltaTime * MySingleClass.SpeedTimer, 0, 0);

	}
	void call_desactivate()
	{
		gameObject.SetActive (false);
	}


	public void desactive()
	{
		Invoke ("call_desactivate", timer_desactive);

	}


	// Update is called once per frame
	void Update ()
	{
	
		mov ();

	}
}


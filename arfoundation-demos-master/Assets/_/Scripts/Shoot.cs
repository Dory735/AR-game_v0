using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject patriciaIdle;
    public GameObject patriciaFly;
    public GameObject patriciaDance;
    public AudioSource danceMusic;
    public AudioSource clickSound;
    public AudioSource broomSound;
    public AudioSource backgroundSoundtrack;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                if(Physics.Raycast(ray,out hit))
                {
                    Debug.Log("Touch on" + hit.transform.name);
                    Debug.Log("Tag: " + hit.transform.tag);

                    if (hit.transform.tag == "Patricia")
                    {
                        clickSound.Play();
                        patriciaIdle.SetActive(false);
                        patriciaFly.SetActive(false);
                        patriciaDance.SetActive(true);
                        patriciaDance.transform.position = patriciaIdle.transform.position;

                        backgroundSoundtrack.Pause();
                        broomSound.Pause();
                        if (danceMusic.isPlaying == false)
                        {
                            danceMusic.Play();
                        }
                        
                    }
                    if (hit.transform.tag == "Broom")
                    {
                        clickSound.Play();
                        patriciaIdle.SetActive(false);
                        patriciaDance.SetActive(false);
                        patriciaFly.SetActive(true);
                        if (danceMusic.isPlaying == true)
                        {
                            danceMusic.Pause();
                        }
                        backgroundSoundtrack.Play();
                        broomSound.Play();

                    }
                    if (hit.transform.tag == "DancingPatricia")
                    {
                        clickSound.Play();
                        patriciaDance.SetActive(false);
                        patriciaIdle.SetActive(true);
                        if (danceMusic.isPlaying == true)
                        {
                            danceMusic.Pause();
                        }
                        backgroundSoundtrack.Play();
                        broomSound.Pause();

                    }

                    if (hit.transform.tag == "FlyingPatricia")
                    {
                        clickSound.Play();
                        broomSound.Pause();
                        patriciaFly.SetActive(false);
                        patriciaIdle.SetActive(true);
                    }

                    /*turret.GetComponent<TurretAI>().currentTarget = hit.transform.gameObject;
                    turret.GetComponent<TurretAI>().Shoot(hit.transform.gameObject);*/

                }
                else
                {
                    Debug.Log("Nothing hit");
                }
            }
        }
    }
}

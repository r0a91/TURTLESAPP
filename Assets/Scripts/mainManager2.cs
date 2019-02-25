using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class mainManager2 : MonoBehaviour
{

    public GameObject popup;
    public GameObject vPlayer, bgMusic;
    //asd
    // Use this for initialization
    void Start()
    {
        //popup = GameObject.Find("PopUpT1");
        //t1Audio = GameObject.Find("Tortuga1Audio");
        bgMusic = GameObject.Find("BackgroundMusic");
    }

    public void cerrarPopUP()
    {
        popup.transform.localScale = Vector3.zero;

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Tortuga"))
        {
            item.GetComponent<CircleCollider2D>().enabled = true;

        }
        vPlayer.GetComponent<VideoPlayer>().Stop();
        //t1Audio.GetComponent<AudioSource>().Stop();
        bgMusic.GetComponent<AudioSource>().Play();

    }

}

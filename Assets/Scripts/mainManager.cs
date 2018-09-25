using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainManager : MonoBehaviour {

	public GameObject popup;
	public GameObject t1Audio, bgMusic;
	//asd
	// Use this for initialization
	void Start () {
		popup = GameObject.Find("PopUpT1");
		t1Audio = GameObject.Find("Tortuga1Audio");
		bgMusic = GameObject.Find("BackgroundMusic");
	}
	
	public void cerrarPopUP(){
		popup.transform.localScale=Vector3.zero;
		
		t1Audio.GetComponent<AudioSource>().Stop();
		bgMusic.GetComponent<AudioSource>().Play();
		
	}

}

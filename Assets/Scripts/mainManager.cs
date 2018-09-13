using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainManager : MonoBehaviour {

	public GameObject popup;
	//asd
	// Use this for initialization
	void Start () {
		popup = GameObject.Find("PopUpT1");
	}
	
	public void cerrarPopUP(){
		popup.transform.localScale=Vector3.zero;
	}

}

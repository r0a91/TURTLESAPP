﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class Comportamiento : MonoBehaviour {
	public CircleCollider2D colider;
	public SkeletonAnimation skeleton;

	public GameObject popup;
	public bool idleActivado, idle2Activado;
	public GameObject t1Audio, bgMusic;

	// Use this for initialization
	void Start () {
		colider = this.GetComponent<CircleCollider2D>();
		skeleton = this.GetComponent<SkeletonAnimation>();
		//popup = GameObject.Find("PopUpTortugaRusa");
		//t1Audio = GameObject.Find("Tortuga1Audio");
		bgMusic = GameObject.Find("BackgroundMusic");
	}
	
	// Update is called once per frame
	void Update () {
	
		//Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		//Debug.Log(GameObject.Find("Tortuga").transform.localPosition);
		if (colider.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
		{	
			idleActivado=false;
			if (idle2Activado==false)
			{	
				idle2Activado=true;
				skeleton.state.SetAnimation(0, "Select", true);	
			}
			if (Input.GetMouseButtonDown(0))
			{
				popup.transform.localScale= Vector3.one;
				

				foreach (GameObject item in GameObject.FindGameObjectsWithTag("Tortuga"))
				{
				item.GetComponent<CircleCollider2D>().enabled = false;
					
				}
				
				
				
				t1Audio.GetComponent<AudioSource>().Play();
				bgMusic.GetComponent<AudioSource>().Pause();
				
				
				
				
			}
			
		}else
		{	
			idle2Activado=false;
			if (idleActivado==false)
			{	
				idleActivado=true;
				skeleton.state.SetAnimation(0, "Idle", true);	
			}
			
		}

	}
}

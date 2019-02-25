using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class Comportamiento3 : MonoBehaviour {
	public CircleCollider2D colider;
	public SkeletonAnimation skeleton;

	public GameObject popup;
	public bool idleActivado, idle2Activado;
	

	// Use this for initialization
	void Start () {
		colider = this.GetComponent<CircleCollider2D>();
		skeleton = this.GetComponent<SkeletonAnimation>();
		//popup = GameObject.Find("PopUpTortugaRusa");
		//t1Audio = GameObject.Find("Tortuga1Audio");
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
				Application.Quit();
				
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

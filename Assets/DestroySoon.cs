using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySoon : MonoBehaviour {
	
	public float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > 10) {
			Health.TakeDamage (10);
			startTime = Time.time;
		}
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 10.0f;
	private float currentx = 0.0f;
	private float currentY = 0.0f;
	private float sensitivityX = 4.0f;
	private float sensitivityy = 1.0f;

	private void Start()
	{
		camTransform = transform;
		cam = Camera.main;


	}

	private void LateUpdate()
	{
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentx, 0);
		camTransform.position = lookAt.position + rotation * dir;
	}


}

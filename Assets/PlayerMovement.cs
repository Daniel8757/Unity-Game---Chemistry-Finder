using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed = 10f;
	public float jumpforce = 15;
	Rigidbody rb;


	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(0, 0, Input.GetAxis ("Vertical") * speed * Time.deltaTime);



		transform.Rotate (0, Input.GetAxis ("Horizontal") * 90 * Time.deltaTime, 0);

		if(Input.GetButtonDown("Jump") && rb.velocity.y == 0)
		{
			rb.velocity = new Vector3 (rb.velocity.x, jumpforce, rb.velocity.z);
		}
		
	}
}

using UnityEngine;

public class AttackWithE : MonoBehaviour {

	public float damage = 100f;
	public float range = 150f;
	public float firerate = 0.1f;

	public Camera tpsCam;
	public GameObject impactEffect;

	private float nextTimeToFire = 0f;

	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire2") && Time.time >= nextTimeToFire ) {
			shoot ();
			nextTimeToFire = Time.time + 1f / firerate;
		}


	}

	void shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast (tpsCam.transform.position, tpsCam.transform.forward, out hit, range)) {

			EnemyDamage target = hit.transform.GetComponent<EnemyDamage> ();

			if (target != null) {
				target.TakeDamage (damage);
			}

			if(hit.rigidbody != null)
			{
				hit.rigidbody.AddForce (-hit.normal * 300f);
			}
				
		}
		GameObject ImpactGo = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
		Destroy (ImpactGo, 6f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Health : MonoBehaviour {

	public Slider healthbar;

	public bool next = true;
	public float currentTime;

	public float nextTimeTakeDamage = 0;

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	public GameObject enemy6;
	public GameObject enemy7;
	public GameObject enemy8;
	public GameObject enemy9;
	public GameObject enemy10;

	public bool bossSpawn = true;

	public GameObject boss;

	public GameObject FinalBoss;

	public static int maxHealth = 100;
	public static int currentHealth = maxHealth;

	public Vector3 myposition;

	public static void TakeDamage(int amount)
	{
		currentHealth = currentHealth - amount;

	}

	void Start()
	{
		healthbar.value = 100;	
		currentHealth = maxHealth;

	}

	void Update()
	{
		healthbar.value = currentHealth;
		if (enemy1 == null && enemy2 == null && enemy3 == null && enemy4 == null && enemy5 == null && enemy6 == null && enemy7 == null && enemy8 == null && enemy9 == null && enemy10 == null && next){
			if (SceneManager.GetActiveScene ().name == "Level 3") {
				if (bossSpawn) {
					Instantiate (boss, new Vector3 (380, 42, 300), Quaternion.identity);
					bossSpawn = false;
				}

			} else {
				next = false;
				currentTime = Time.time;
			}

		}
		if (next == false && Time.time - currentTime > 15) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}

		if (currentHealth <= 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}

		myposition = transform.position;
		if (myposition[1]<25.5 && Time.time >= nextTimeTakeDamage && SceneManager.GetActiveScene().name == "Level 3") {
			nextTimeTakeDamage = Time.time + 8;
			currentHealth = currentHealth - 4;

		}



	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour {

	public GameObject QuestionAsk;
	public GameObject QuestionAsk2;
	public GameObject QuestionAsk3;
	public GameObject QuestionAsk4;
	public GameObject QuestionAsk5;
	public GameObject QuestionAsk6;
	public GameObject QuestionAsk7;
	public GameObject QuestionAsk8;
	public GameObject QuestionAsk9;

	public bool isBoss;

	public float health;

	public bool l2700 = true;
	public bool l2400 = true;
	public bool l2100 = true;
	public bool l1800 = true;
	public bool l1500 = true;
	public bool l1200 = true;
	public bool l900 = true;
	public bool l600 = true;
	public bool l300 = true;


	public void TakeDamage(float amount)
	{
		health -= amount;
		if (isBoss) {

			if (health <= 2700 && l2700) {
				Instantiate (QuestionAsk);
				l2700 = false;
			} else if (health <= 2400 && l2400) {
				Instantiate (QuestionAsk2);
				l2400 = false;
			} else if (health <= 2100 && l2100) {
				Instantiate (QuestionAsk3);
				l2100 = false;
			} else if (health <= 1800 && l1800) {
				Instantiate (QuestionAsk4);
				l1800 = false;
			} else if (health <= 1500 && l1500) {
				Instantiate (QuestionAsk5);
				l1500 = false;
			} else if (health <= 1200 && l1200) {
				Instantiate (QuestionAsk6);
				l1200 = false;
			} else if (health <= 900 && l900) {
				Instantiate (QuestionAsk7);
				l900 = false;
			} else if (health <= 600 && l600) {
				Instantiate (QuestionAsk8);
				l600 = false;
			} else if (health <= 300 && l300) {
				Instantiate (QuestionAsk9);
				l300 = false;
			}
			else if(health<=0){
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
			}


		} else {
			if (health <= 0f) {
				Die ();
			}
		}
	}

	void Die(){
		Instantiate (QuestionAsk);
		Destroy (gameObject);
	}
		
}

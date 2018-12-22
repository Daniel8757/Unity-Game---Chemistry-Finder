using UnityEngine;

public class BossScript : MonoBehaviour {

	public GameObject QuestionAsk;
	public GameObject QuestionAsk2;
	public GameObject QuestionAsk3;
	public GameObject QuestionAsk4;
	public GameObject QuestionAsk5;
	public GameObject QuestionAsk6;
	public GameObject QuestionAsk7;
	public GameObject QuestionAsk8;
	public GameObject QuestionAsk9;

	public float health = 100f;

	public void TakeDamage(float amount)
	{
		health -= amount;
		if (health <= 0f) {
			Die ();
		}
	}

	void Die(){
		Destroy (gameObject);
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour{

	public GameObject projectile;
	public float projectileSpeed=10;
	public float health=150;
	public float shotsPerSeconds=0.5f;
	public int scoreValue = 150;

	public AudioClip fireSounds;
	public AudioClip deathSounds;
	public AudioClip win;

	private ScoreKeeper scoreKeeper;

	void Start(){
		scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
	}

	void Update(){
		float probability = Time.deltaTime * shotsPerSeconds;
		if(Random.value < probability){
			Fire();
		}
	}
		void Fire(){
		GameObject missile = Instantiate(projectile,transform.position,Quaternion.identity) as GameObject;
		missile.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-projectileSpeed);
		AudioSource.PlayClipAtPoint(fireSounds, transform.position, 0.2f);
		}
	void OnTriggerEnter2D (Collider2D collider){
	Projectile missile = collider.gameObject.GetComponent<Projectile>();
	if(missile){
		health -= missile.GetDamage();
		missile.Hit();
		if(health<=0){
			AudioSource.PlayClipAtPoint(deathSounds, transform.position);
			Destroy(gameObject);
			scoreKeeper.Score(scoreValue);
			AudioSource.PlayClipAtPoint(win, transform.position, 1f);
			}
		}
	}
}
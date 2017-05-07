using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {
	public float width = 10f;
	public float height = 5f;

	//void OnTriggerEnter2D(Collider2D col){
		//Destroy(col.gameObject);
		//}

	public void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
	}
}

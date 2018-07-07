using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadBehaviour : MonoBehaviour {

	public float jumpForce = 10f;

	void OnCollisionEnter2D(Collision2D other){
		if(other.relativeVelocity.y <= 0){
			Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
			if( rb != null) {
				rb.velocity = new Vector2(0,jumpForce);
			}
		}
	} 
}

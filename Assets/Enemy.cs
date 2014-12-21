using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform[] waypoints;
	public int current;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance( waypoints[ current ].position, transform.position );
		Vector2 direction = (waypoints [current].position - transform.position).normalized;
		rigidbody2D.velocity = direction * 2;
		if ( distance < 1 ) {
			current++;
		}
	}
}

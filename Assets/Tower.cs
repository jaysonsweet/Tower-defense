using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	public Transform target;
	public GameObject bullet;
	public float fireRate;
	private float fireTime;

	// Use this for initialization
	void Start () {
		target = GameObject.Find( "Enemy" ).transform;
	}
	
	// Update is called once per frame
	void Update () {

		fireTime -= Time.deltaTime;

		if ( fireTime < 0 ) {
			GameObject newBullet = Instantiate( bullet ) as GameObject;
			newBullet.transform.position = transform.position;
			newBullet.rigidbody2D.velocity = (target.transform.position - transform.position).normalized * 5;
			fireTime = fireRate;
		}
	}
}

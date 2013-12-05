using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.rigidbody2D.AddForce(new Vector2(200, 200));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

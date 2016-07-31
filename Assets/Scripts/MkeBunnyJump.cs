using UnityEngine;
using System.Collections;

public class MkeBunnyJump : MonoBehaviour {
	public Rigidbody2D rb;
	public float jumpForce;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("space")){
			rb.AddForce(transform.up * jumpForce);
		}
	}
}

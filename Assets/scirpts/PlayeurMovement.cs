using UnityEngine;
using System.Collections;

public class PlayeurMovement : MonoBehaviour {

	public float movementSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (x,y);
		transform.Translate (movement * movementSpeed * Time.deltaTime);
	}
}

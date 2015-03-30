using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float movementSpeed;
	public CollectableManager collectableManager;
	private Animator animatorController;


	private ParallaxController _parallaxController;

	void Awake()
	{
		_parallaxController = GetComponent<ParallaxController> ();
		animatorController = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.anyKey) {
			animatorController.SetBool ("isIdle", false);

			if (Input.GetKey (KeyCode.A)) {
				transform.rotation = new Quaternion (0, 180, 0, 0);
				float x = Input.GetAxis ("Horizontal");
				Vector2 movement = new Vector2 (-x, 0f);
				transform.Translate (movement * movementSpeed * Time.deltaTime);
				_parallaxController.Scroll (movement *= -1);
				animatorController.SetBool ("isWalking", true);

			}

			if (Input.GetKey (KeyCode.D)) {
				transform.rotation = new Quaternion (0, 0, 0, 0);
				float x = Input.GetAxis ("Horizontal");
				Vector2 movement = new Vector2 (x, 0f);
				transform.Translate (movement * movementSpeed * Time.deltaTime);
				_parallaxController.Scroll (movement *= -1);
				animatorController.SetBool ("isWalking", true);

			}
		} else {
			animatorController.SetBool ("isWalking", false);
			animatorController.SetBool ("isIdle", true);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Collectable")
		{
			Destroy(other.gameObject);
			collectableManager.AddCollectable();
		}
		
	}
}

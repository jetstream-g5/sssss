using UnityEngine;
using System.Collections;

public class Jumperino : MonoBehaviour {
	public int jump;
	//public bool IsOnGround;
	public int jumpCount;

	private Rigidbody2D rb2d;
	// Use this for initialization
	/* void OnCollisionStay (Collision2D, collisionInfo)
    {
        if (JumpCount == 0)
        {
           IsOnGround = true;
        }
    }

    void OnCollisionExit (Collision2D, collisionInfo)
    {
        if(JumpCount > 0)
        {
        IsOnGround = false;
        }
    }*/
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		Debug.Log (rb2d);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
		{
			rb2d.AddForce(new Vector2(0, jump));
			jumpCount ++;
			if(jumpCount >1)
			{
				jumpCount = 0;

			}
		}
		
	}
}

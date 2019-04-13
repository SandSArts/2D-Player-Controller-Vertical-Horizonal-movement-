//Programmed by Shashank - Creator of SandS Arts ,Mail me at sandsarts.developer@gmail.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	Rigidbody2D rb;
	SpriteRenderer player;
	Animator anim;


	void Start () {
		//references of all the things that we need
		rb = GetComponent<Rigidbody2D> ();
		player = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
	}
	
	//Physics things are performed in this function
	void FixedUpdate () {
		Movement ();
	}

	float horizontalMovement;
	public float horizontalspeed;
	public float verticalspeed;
	float verticalMovement;

	void Movement()
	{
		//Inputs from the user
		horizontalMovement = Input.GetAxisRaw("Horizontal") * horizontalspeed;
		verticalMovement = Input.GetAxisRaw ("Vertical") * verticalspeed;

		if (horizontalMovement > 0)
			transform.eulerAngles = new Vector3 (0,0,0);
			//	player.flipX = false;
		else if (horizontalMovement < 0)
			transform.eulerAngles = new Vector3 (0,180f,0);                                                   //if childs must be flipped
			//player.flipX = true;                                                                                                                        //if childs need not to be flipped

		/* Animation Controller
		if (horizontalMovement != 0)
			anim.SetBool ("Walk", true);
		else
			anim.SetBool ("Walk", false);
	*/

		//Changing velocity to the player
		rb.velocity = new Vector2 (horizontalMovement,verticalMovement); //Changing velocity of only x and y

		rb.velocity = new Vector2 (horizontalMovement,rb.velocity.y);                //Changing velocity of only x 
	
	}
}

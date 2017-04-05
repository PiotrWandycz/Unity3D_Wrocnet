using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
	
    private float _speed;

    void Start()
    {
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
		_speed = 5.0f;
    }

    void FixedUpdate()
    {
		HandleMovement(_rigidbody, _speed);
		HandleJumping(_rigidbody, _speed);
    }

	void HandleMovement(Rigidbody2D rigidbody, float speed)
	{
		if(Input.GetAxis("Horizontal") != 0.0f)
		{
			rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed , rigidbody.velocity.y);
		}
	}	

	void HandleJumping(Rigidbody2D rigidbody, float jumpHeight)
	{
		if(Input.GetButtonDown("Jump"))
		{
			rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpHeight);
		}
	}
}

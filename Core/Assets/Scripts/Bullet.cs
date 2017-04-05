using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    void Start()
    {
			SetupComponents();
    }

    void Update()
    {
			MoveRight();
    }

	void SetupComponents()
	{
		_rigidbody = gameObject.AddComponent<Rigidbody2D>();
		_rigidbody.gravityScale = 0.0f;
	}

	void MoveRight()
	{
		var newPosition = new Vector2(5.0f * Time.fixedDeltaTime, 0.0f);
		_rigidbody.MovePosition(_rigidbody.position + newPosition);
	}
}

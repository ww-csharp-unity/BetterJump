using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{

	public float fallSpeed;
	public float lowJumpHeight;

	Rigidbody rb;

	private void Awake()
	{
		fallSpeed = 8f;
		lowJumpHeight = 6f;
		rb = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (rb.velocity.y < 0)
		{
			rb.velocity += Vector3.up * Physics.gravity.y * (fallSpeed - 1) * Time.deltaTime;
		}
		else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
		{
			rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpHeight - 1) * Time.deltaTime;
		}
	}
}

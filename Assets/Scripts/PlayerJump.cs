using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour 
{
	public float fallSpeed = 20f;
	public float jumpSpeed = 8f;
	Rigidbody _r;
	Vector3 _v;

	void Awake()
	{
		_r = rigidbody;
		_v = Vector3.zero;
	}

	void Update () 
	{
		_v -= Vector3.up * fallSpeed * Time.deltaTime;
		_r.velocity = _v;
	}

	void DoJump()
	{
		_v = jumpSpeed * Vector3.up;
	}
}

using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float jumphight = 5f;
	
	void Update () {

		if (Input.GetButtonDown("Fire1")) 
		{
			Debug.Log("jump");

			// transform.rotation *= Quaternion.Euler( new Vector3(0f, 0f,1) * rotateSpeed * Time.deltaTime);
			//object.rigidboady.AddForce(Vector3.up * jumphight);
		}

	
		
	}
}

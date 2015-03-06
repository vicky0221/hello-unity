using UnityEngine;
using System.Collections;

public class BGScroll : MonoBehaviour {

	public float speed = 0.1f;
	
//	void Start ()
//	{
//		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1)); // full size 
//		Vector2 scale = max * 2;
//		transform.localScale = scale;
//	}
	
	void Update ()
	{
		float y = Mathf.Repeat (Time.time * speed, 1);
		Vector2 offset = new Vector2 (0, y);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}

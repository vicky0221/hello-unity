using UnityEngine;
using System.Collections;

public class DoJump : MonoBehaviour {

	public GameObject target;

	public void Action()
	{
		target.SendMessage("DoJump");
	}

}

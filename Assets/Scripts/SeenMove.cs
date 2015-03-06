using UnityEngine;
using System.Collections;

public class SeenMove : MonoBehaviour {
	
	public int sceneNo;
	public void Move(){
		Debug.Log (sceneNo);
		Application.LoadLevel (sceneNo);
		// Application.LoadLevelAsync
	}
}

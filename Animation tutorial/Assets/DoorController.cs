using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {


	public Animator animator;
	public Rect openDoorRectangle;
	public Rect closeDoorRectangle;

	void Start () {
		animator = GetComponent<Animator> ();
	}
	

	void OnGUI () 
	{

		if (GUI.Button (openDoorRectangle, "Open Door")) 
		{
			animator.SetInteger ("Door Open", 1);
			animator.SetInteger ("Door Close", 0);
		}

		if (GUI.Button (closeDoorRectangle, "Close Door"))
		{
			animator.SetInteger ("Door Open", 0);
			animator.SetInteger ("Door Close", 1);
		}
	}
}

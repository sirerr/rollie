using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorOpen : BasicWorldAction {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public override void InteractStart()
	{
		anim.SetBool ("interact", true);
	}

	// Update is called once per frame
	void Update () {
 
	}

	#if UNITY_EDITOR
	void OnMouseUp()
	{
		InteractStop();
	}

	void OnMouseDown()
	{
		InteractStart();
	}
	#endif
}

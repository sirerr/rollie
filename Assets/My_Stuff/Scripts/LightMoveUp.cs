using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMoveUp : BasicWorldAction {


	public bool moveup = false;
	public bool levertrig = false;
	public bool trigger2 = false;
	public Animator anim;
	public float YSpeed = .3f;
	float startY;
	float MaxDistance = .17f;
    public BasicWorldAction DoorAction;
	void Start()


	{
		startY = transform.position.y;
	
	}


	// Update is called once per frame
	void Update ()
	{
		//		if (Input.GetMouseButtonDown(0))
		//		{
		//			Vector3 = wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//			PolygonCollider2D coll =

		if (moveup && transform.position.y < (startY + MaxDistance)) {
			this.transform.Translate (0, YSpeed * Time.deltaTime, 0);
							

			//rigidbody.MoveRotation(rigidbody.rotation - 0.5f);
		} else if(moveup) {
			levertrig = true;
		}
		if (levertrig == true && trigger2 == false)
		{
			//print ("disguy");
			anim.SetBool ("lightturn", true);
			trigger2 = true;
            DoorAction.InteractStart();
		}
	}



	public override void InteractStart()
	{
		moveup = true;
	}

	public override void InteractStop()
	{
		moveup = false;
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

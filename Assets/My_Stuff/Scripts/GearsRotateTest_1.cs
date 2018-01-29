using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearsRotateTest_1 : BasicWorldAction {

	public List<Rigidbody2D> GearsSame = new List<Rigidbody2D>();
	public List<Rigidbody2D> GearsOpposite = new List<Rigidbody2D>();

	private bool rotating = false;
	private Rigidbody2D rigidbody;

	void Awake ()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		if (!rigidbody) {
			Debug.LogWarning (name + " does not have a RigidBody 2D");
		}
	}
    
	// Update is called once per frame
	void FixedUpdate ()
	{
//		if (Input.GetMouseButtonDown(0))
//		{
//			Vector3 = wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//			PolygonCollider2D coll =

		if (rotating) {
			//this.transform.Rotate (0, 0, -1);
			rigidbody.MoveRotation(rigidbody.rotation - 0.5f);

			for (int i = 0; i < GearsSame.Count; i++)
			{
				GearsSame[i].MoveRotation (GearsSame[i].rotation - 0.5f);
				//GearsSame[i].Rotate (0, 0, -1);
			}
			for (int i = 0; i < GearsOpposite.Count; i++)
			{
				GearsOpposite[i].MoveRotation (GearsOpposite[i].rotation + 0.5f);
				//GearsOpposite[i].Rotate (0, 0, 1);
			}
		}
	}

	public override void InteractStart()
	{
		rotating = true;
	}

	public override void InteractStop()
	{
		rotating = false;
	}
    
}

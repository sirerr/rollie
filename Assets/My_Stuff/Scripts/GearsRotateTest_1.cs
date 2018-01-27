using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearsRotateTest_1 : BasicWorldAction {

	public List<Transform> GearsSame = new List<Transform>();
	public List<Transform> GearsOpposite = new List<Transform>();

	private bool rotating = false;


	// Update is called once per frame
	void Update ()
	{
//		if (Input.GetMouseButtonDown(0))
//		{
//			Vector3 = wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//			PolygonCollider2D coll =

		if (rotating) {
			this.transform.Rotate (0, 0, -1);
			for (int i = 0; i < GearsSame.Count; i++)
			{
				GearsSame[i].Rotate (0, 0, -1);
			}
			for (int i = 0; i < GearsOpposite.Count; i++)
			{
				GearsOpposite[i].Rotate (0, 0, 1);
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

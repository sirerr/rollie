using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWorldAction : MonoBehaviour {

    public bool continuous = false;

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

    public virtual void InteractStart()
	{
	}

	public virtual void InteractStop()
	{
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDtoTwoDInteractor : BasicWorldAction {

    public override void InteractStart()
    {
        transform.parent.GetComponent<BasicWorldAction>().InteractStart();
    }

    public override void InteractStop()
    {
        transform.parent.GetComponent<BasicWorldAction>().InteractStop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearAffector : BasicWorldAction {

    public GameObject ButtonOn;
    public GameObject ButtonOff;

    public override void InteractStart()
    {
        base.InteractStart();
        ButtonOn.SetActive(true);
        ButtonOff.SetActive(false);
    }

    public override void InteractStop()
    {
        base.InteractStop();
        ButtonOn.SetActive(false);
        ButtonOff.SetActive(true);
    }

}

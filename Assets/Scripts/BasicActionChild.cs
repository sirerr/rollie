using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicActionChild : BasicWorldAction {

    public float speed =2f;

    public override void InteractStart()
    {
        base.InteractStart();
        transform.Translate(transform.up * speed * Time.deltaTime);

    }

    public override void InteractStop()
    {
        base.InteractStop();
        continuous = false;
    }

}

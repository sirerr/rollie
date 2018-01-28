using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringUp : BasicWorldAction
{

    public Animator anim;
    public Launcher launcher;

    Rigidbody2D contacting;
    bool clicked;

    void Awake()
    {
        anim = GetComponent<Animator>();
        launcher.SetSpring(this);
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

    public void DoSpringUp()
    {
        if (!clicked)
        {
            anim.SetBool("springuppng", true);
            launcher.Launch();
            clicked = true;
        }
    }
}

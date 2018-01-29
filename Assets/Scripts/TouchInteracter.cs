using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchInteracter : MonoBehaviour
{

    public LayerMask lmask;
    public float raylength = 50;
    Camera cam;
    GameObject objHit;
    BasicWorldAction[] basicActions;
    public Text testingText;
    void Awake()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit rhit;
        GameObject newObjHit = null;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out rhit, raylength, lmask.value))
        {
            newObjHit = rhit.transform.gameObject;
            testingText.text = "hitting obj";
        }
        else
        {
            testingText.text = "not hitting obj";
        }

        if (Input.touchCount > 0)
        {
            Touch tap = Input.GetTouch(0);

            switch (tap.phase)
            {
                case TouchPhase.Began:
                    if (newObjHit != null)
                    {
                        objHit = newObjHit;
                        basicActions = objHit.GetComponents<BasicWorldAction>();
                        for (int i = 0; i < basicActions.Length; i++)
                            basicActions[i].InteractStart();
                    }
                    break;
                case TouchPhase.Moved:
                case TouchPhase.Stationary:
                    if (newObjHit != objHit)
                    {
                        if (objHit != null)
                        {
                            for (int i = 0; i < basicActions.Length; i++)
                                basicActions[i].InteractStop();
                        }
                        objHit = newObjHit;
                        if (objHit != null)
                        {
                            basicActions = objHit.GetComponents<BasicWorldAction>();
                            for (int i = 0; i < basicActions.Length; i++)
                                basicActions[i].InteractStart();
                        }
                    }
                    break;

                case TouchPhase.Ended:
                    if (objHit != null)
                    {
                        for (int i = 0; i < basicActions.Length; i++)
                            basicActions[i].InteractStop();
                        objHit = null;
                        basicActions = null;
                    }
                    break;

            }
        }


    }
}

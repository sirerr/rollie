using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchInteracter : MonoBehaviour {

    public LayerMask lmask;
   public  float raylength = 50;
    Camera cam;
    GameObject objHit;
    BasicWorldAction basicAction;
    public Text testingText;
    void Awake()
    {
        cam = Camera.main;
    }
	// Update is called once per frame
	void Update () {
        RaycastHit rhit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out rhit, raylength, lmask.value))
        {
            objHit = rhit.transform.gameObject;
            basicAction = rhit.transform.GetComponent<BasicWorldAction>();
            testingText.text = "hitting obj";
        }
        else
        {
            testingText.text = "not hitting obj";
        }

        if (Input.touchCount>0)
        {
            Touch tap = Input.GetTouch(0);

            switch (tap.phase)
                {
                    case TouchPhase.Began:
                    if(objHit!=null)
                    {
                        basicAction.InteractStart();
                    }
                    break;
                    case TouchPhase.Moved:
                    if(objHit!=null)
                    {
                        basicAction.InteractStop();
                        objHit = null;
                        basicAction = null;

                    }
                    break;

                case TouchPhase.Stationary:
                    if(objHit!=null)
                    {
                        basicAction.InteractStart();
                    }
                    break;
                    case TouchPhase.Ended:
                    if(objHit!=null)
                    {
                        basicAction.InteractStop();
                        objHit = null;
                        basicAction = null;
                    }
                    break;

                }
        }


	}
}

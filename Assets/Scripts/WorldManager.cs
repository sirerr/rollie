using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WorldManager : MonoBehaviour {

    public enum WorldSet { set,notset };
    public WorldSet PlayReady;
    public GameObject deathArea;
    public Camera cam;
    public LayerMask lmask;
    public Text testText;
    // placement of the level;
    public GameObject level0;
    public GameObject startbutton;

    void Start () {
        PlayReady = WorldSet.notset;
      //  SceneManager.LoadScene(1, LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, Mathf.Infinity, lmask.value))
        {
            testText.text = "seeing";
        }else
        {
            testText.text = "not seeing";
        }


    }

   public  void UserInput()
    {
        RaycastHit rhit;

        if(Physics.Raycast(cam.transform.position,cam.transform.forward, out rhit,Mathf.Infinity,lmask.value) && PlayReady == WorldSet.notset)
        {
            PlayReady = WorldSet.set;

            level0.SetActive(true);
            level0.transform.position = rhit.point;

            deathArea.SetActive(true);
            deathArea.transform.position = rhit.point;
            startbutton.SetActive(false);
        }
    }
}

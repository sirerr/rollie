using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShip : MonoBehaviour 
{
	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		print ("got hit by something");
			anim.SetBool ("FlyAway", true);
			collision.gameObject.SetActive (false);
        StartCoroutine(SmallWait());
	}

    IEnumerator SmallWait()
    {
        yield return new WaitForSeconds (2f);
        WorldManager.manager.Level2();
    }
}

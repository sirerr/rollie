using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {
	public float force = 10f;
	Rigidbody2D contacting;
    SpringUp spring;
    public void SetSpring(SpringUp spring)
    {
        this.spring = spring;
    }

    void FixedUpdate()
	{
		contacting = null;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
        if (col.rigidbody != null)
		    contacting = col.rigidbody;
        else if (col.otherRigidbody != null)
            contacting = col.otherRigidbody;
        if (contacting != null)
        {
            spring.DoSpringUp();
        }
    }

    public void Launch()
    {
        contacting.AddForce(transform.up * force, ForceMode2D.Impulse);
    }
}

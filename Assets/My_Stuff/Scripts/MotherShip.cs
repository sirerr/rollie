using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShip : MonoBehaviour 
{

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "RollieDude")
		{
			collision.gameObject.SetActive (false);
		}
			
	}
}

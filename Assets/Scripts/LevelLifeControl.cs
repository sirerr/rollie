using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLifeControl : MonoBehaviour {

    public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D col)
    {
        print("there has been a hit");
        col.gameObject.transform.position = spawnPoint.position;

    }


}

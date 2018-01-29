using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLifeControl : MonoBehaviour {

    public GameObject player;
    public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D col)
    {
        print("there has been a hit");
        ResetPlayer();
    }

    public void ResetPlayer()
    {
        player.transform.position = spawnPoint.position;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        player.GetComponent<Rigidbody2D>().angularVelocity = 0f;
    }

}

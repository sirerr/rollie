using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour {

    public GameObject playerChar;
    public Transform spawnpoint;
    void OnEnable()
    {
        playerChar.SetActive(true);
        playerChar.transform.position = spawnpoint.position;
    }

}

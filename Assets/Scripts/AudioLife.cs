using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLife : MonoBehaviour {

    public AudioClip mainMusic;
    public List<AudioClip> SoundEffects = new List<AudioClip>();
    public AudioSource ASource;

    void OnEnable()
    {

        ASource.PlayOneShot(mainMusic);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

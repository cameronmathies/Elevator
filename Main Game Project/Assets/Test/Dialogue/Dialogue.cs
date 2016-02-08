using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {
    public AudioSource[] sounds;
    public AudioSource noise1;
    public AudioSource noise2;
    // Use this for initialization
    void Start () {
        sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
        noise2 = sounds[1];
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Y))
        {
            noise1.Play();
        }
        if (Input.GetKey(KeyCode.N))
        {
            noise2.Play();
        }

    }
}

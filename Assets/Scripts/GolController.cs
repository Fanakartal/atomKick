using UnityEngine;
using System.Collections;

public class GolController : MonoBehaviour {

    //AudioSource source;
    public AudioClip clip;
    
    // Use this for initialization
	void Start () {
        //source.audio.clip = clip;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
            audio.PlayOneShot(clip);

            //source.PlayOneShot(clip);
            //Debug.Log("Goooooooool!!!!");
    }
}

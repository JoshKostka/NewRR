using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
// Joshua Kostka - Updated 1/12/22
*/
public class VoiceLinePlayer : MonoBehaviour
{

    // Get the clip from Inspector and assign audiosource from gameobject script attached to
    [SerializeField] AudioClip clip;
    AudioSource aSrc;



    private void Awake()
    {
        aSrc = this.gameObject.GetComponent<AudioSource>();
    }

    // Play the script
    public void Go()
    {
        aSrc.clip = clip;
        aSrc.Play();
    }

    // Stop playing Audio
    public void Stop()
    {
        aSrc.Stop();
    }
}

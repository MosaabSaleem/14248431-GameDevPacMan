using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource footstepSource;
    public AudioClip[] footstepClips;

    // Update is called once per frame
    void Update()
    {
        if (footstepSource.clip == footstepClips[0] && !footstepSource.isPlaying)
        {
            footstepSource.clip = footstepClips[1];
            footstepSource.Play();
        }
        else if (footstepSource.clip == footstepClips[1] && !footstepSource.isPlaying)
        {
            footstepSource.clip = footstepClips[0];
            footstepSource.Play();
        }
    }
}

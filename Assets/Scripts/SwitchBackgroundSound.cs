using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBackgroundSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip mainMenuAudio;
    public AudioClip normalBackgroundAudio;
    void Start()
    {
        AudioSource backgroundSound = GetComponent<AudioSource>();
        backgroundSound.clip = mainMenuAudio;
        backgroundSound.Play();
        backgroundSound.loop = false;
        new WaitForSeconds(mainMenuAudio.length);
        backgroundSound.clip = normalBackgroundAudio;
        backgroundSound.Play();
        backgroundSound.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

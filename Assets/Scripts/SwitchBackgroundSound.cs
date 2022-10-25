using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBackgroundSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip mainMenuAudio;
    public AudioClip normalBackgroundAudio;
    public AudioSource backgroundSource;
    void Start()
    {
        StartCoroutine(BackgroundWait());
    }

    IEnumerator BackgroundWait()
    {
        backgroundSource.clip = mainMenuAudio;
        backgroundSource.Play();
        backgroundSource.loop = false;
        yield return new WaitForSeconds(mainMenuAudio.length);
        backgroundSource.clip = normalBackgroundAudio;
        backgroundSource.Play();
        backgroundSource.loop = true;
    }

    private void Update()
    {
        
    }
}

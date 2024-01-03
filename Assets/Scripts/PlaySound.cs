using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlaying = false;
    public float delayBetweenSounds = 5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTrackingFound()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            InvokeRepeating("PlaySoundWithDelay", 0f, delayBetweenSounds);
        }
    }

    public void OnTrackingLost()
    {
        if (isPlaying)
        {
            isPlaying = false;
            CancelInvoke("PlaySoundWithDelay");
            audioSource.Stop();
        }
    }

    void PlaySoundWithDelay()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}

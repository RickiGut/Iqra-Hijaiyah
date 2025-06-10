using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobaAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] audioHijaiyah;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayHijaiyah(int index)
    {
        audioSource.PlayOneShot(audioHijaiyah[index]);
    }
}

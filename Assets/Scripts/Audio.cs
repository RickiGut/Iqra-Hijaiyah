using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource source;
    public AudioClip[] audioIqra;
    void Start()
    {
        source = GetComponent<AudioSource>(); 
    }

    public void PlayAudio(int index)
    {
        source.PlayOneShot(audioIqra[index]);
    }
}

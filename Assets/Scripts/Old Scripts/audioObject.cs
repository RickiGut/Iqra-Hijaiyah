using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioObject : MonoBehaviour
{
    public AudioSource audioSource;

    [SerializeField] AudioClip alif;
    [SerializeField] AudioClip ba;
    [SerializeField] AudioClip dal;
    [SerializeField] AudioClip dzal;
    [SerializeField] AudioClip ha;
    [SerializeField] AudioClip jim;
    [SerializeField] AudioClip kha;
    [SerializeField] AudioClip ra;
    [SerializeField] AudioClip sin;
    [SerializeField] AudioClip ta;
    [SerializeField] AudioClip tsa;
    [SerializeField] AudioClip za;

    [SerializeField] AudioClip SFXButton;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAlif()
    {
        audioSource.PlayOneShot(alif);
    }
    public void PlayBa()
    {
        audioSource.PlayOneShot(ba);
    }
    
    public void PlayDal()
    {
        audioSource.PlayOneShot(dal);
    }
    
    public void PlayDzal()
    {
        audioSource.PlayOneShot(dzal);
    }
    
    public void PlayHa()
    {
        audioSource.PlayOneShot(ha);
    }
    
    public void PlayJim()
    {
        audioSource.PlayOneShot(jim);
    }
    
    public void PlayKha()
    {
        audioSource.PlayOneShot(kha);
    }
    
    public void PlayRa()
    {
        audioSource.PlayOneShot(ra);
    }
    
    public void PlaySin()
    {
        audioSource.PlayOneShot(sin);
    }
    
    public void PlayTa()
    {
        audioSource.PlayOneShot(ta);
    }
    
    public void PlayTsa()
    {
        audioSource.PlayOneShot(tsa);
    }
    
    public void PlayZa()
    {
        audioSource.PlayOneShot(za);
    }

}

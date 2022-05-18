using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    //clip de audio para la muerte de Mario
    public AudioClip deathSFX;
    public AudioClip jumpSFX;
    public AudioClip crunchSFX;
    public AudioClip injuredSFX;
    public AudioClip flagSFX;

    //variable del audio source
    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void DeathSound()
    {
        _audioSource.PlayOneShot(deathSFX);
    }

    public void JumpSound()
    {
        _audioSource.PlayOneShot(jumpSFX);
    }

    public void CrunchSound()
    {
        _audioSource.PlayOneShot(crunchSFX);
    }

    public void injuredSound()
    {
        _audioSource.PlayOneShot(injuredSFX);
    }

    public void FlagSound()
    {
        _audioSource.PlayOneShot(flagSFX);
    }
    

}

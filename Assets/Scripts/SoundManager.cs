using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    public AudioClip click;
    public AudioClip endTurn;
    AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = instance.GetComponent<AudioSource>();
    }

    public void playSound(AudioClip clip, float pitch)
    {
        instance.audioSource.clip = clip;
        instance.audioSource.pitch = pitch;
        audioSource.Play();
    }

}

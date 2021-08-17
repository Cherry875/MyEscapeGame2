using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioItem : MonoBehaviour
{
    public AudioClip get;
    public AudioClip select;
    AudioSource audioSource;    

    public static AudioItem ADI;
    void Awake()
    {
        ADI = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayGetSound()
    {
        audioSource.PlayOneShot(get, 0.7F);
    }
    
    public void PlaySelectSound()
    {
        audioSource.PlayOneShot(select, 0.7F);
    }

}

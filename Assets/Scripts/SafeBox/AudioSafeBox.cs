using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSafeBox : MonoBehaviour
{
    public AudioClip click;
    public AudioClip open;
    AudioSource audioSource;

    public static AudioSafeBox ASB;
    void Awake()
    {
        ASB = this;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayClickSound()
    {
        audioSource.PlayOneShot(click, 0.7F);
    }

    public void PlayOpenSound()
    {
        audioSource.PlayOneShot(open, 0.7F);
    }

}

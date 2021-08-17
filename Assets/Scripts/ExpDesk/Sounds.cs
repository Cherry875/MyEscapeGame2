using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip pour;
    AudioSource audioSource;      
    
    public static Sounds SND;
    private void Awake ()
    {
        SND = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPourSounds()
    {
        audioSource.PlayOneShot(pour, 0.7F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

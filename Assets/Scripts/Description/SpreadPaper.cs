using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpreadPaper : MonoBehaviour
{
    public Image PaperDSC;
    public Sprite spread_paper;

    public bool already;

    //音の設定
    public AudioClip spread;
    AudioSource audioSource; 
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        already = false;
    }

    public void OnPaperDSC()
    {
        PaperDSC.sprite = spread_paper;
        if(!already)
        {
            PlaySpreadSound();
        }
        already = true;
    }

    private void PlaySpreadSound()
    {
        audioSource.PlayOneShot(spread, 0.7F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

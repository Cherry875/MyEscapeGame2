using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBackToTitle : MonoBehaviour
{
    public Image StartButton;
    public AudioClip start_sound;
    AudioSource audioSource; 

    private Color color1,color2,color3;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }    

    public void OnClick()
    {
        audioSource.PlayOneShot(start_sound, 0.7F);
        Invoke("GoBack",1.0f);
    }

    public void OnEnter()
    {
        Color c = StartButton.color;
        StartButton.color=new Color(c.r,c.b,c.g,0.7f);
    }

    public void OnExit()
    {
        Color c = StartButton.color;
        StartButton.color=new Color(c.r,c.b,c.g,1);
    }

    private void GoBack()
    {
        SceneManager.LoadScene("Title");
    }
}

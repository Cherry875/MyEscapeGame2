using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public AudioClip closed;
    public AudioClip key_open;
    public AudioClip escaped;
    AudioSource audioSource;

    public GameObject ClosedDoor;
    public GameObject OpenDoor; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ClosedDoor.SetActive(true);
        OpenDoor.SetActive(false);        
    }     
    
    public void ClickDoor()
    {
        if(UseItem.SelectedItem == Item.ItemType.TrueKye)
        {
            audioSource.PlayOneShot(key_open, 0.7F);
            Invoke("DoOpenDoor",1.0f);
            Invoke("PlayEscapeSound",1.8f);
            Invoke("GoToEnding",4.0f);
        }
        else
        {
            audioSource.PlayOneShot(closed, 0.7F);
        }
    }

    private void PlayEscapeSound()
    {
        audioSource.PlayOneShot(escaped, 0.7F);
    }

    private void DoOpenDoor()
    {
        ClosedDoor.SetActive(false);
        OpenDoor.SetActive(true);
    }

    private void GoToEnding()
    {
        SceneManager.LoadScene("Ending");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

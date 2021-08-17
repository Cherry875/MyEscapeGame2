using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetJar : MonoBehaviour
{
    public GameObject SmallJar;
    public GameObject Noreaction;
    public GameObject Stand;
    public AudioClip setjar;
    AudioSource audioSource; 


    // Start is called before the first frame update
    void Start()
    {
        Noreaction.SetActive(false);
        Stand.SetActive(true);
        SmallJar.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void SetSmallJar()
    {
        if(UseItem.SelectedItem == Item.ItemType.Jar)
        {
            SmallJar.SetActive(true);
            PlaySettingSound();
            ItemBox.IBX.DeleteItem(Item.ItemType.Jar);
        }
    }

    private void PlaySettingSound()
    {
        audioSource.PlayOneShot(setjar, 0.7F);
    }

}

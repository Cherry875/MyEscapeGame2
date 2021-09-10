using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenShelf : MonoBehaviour
{
    //オブジェクトの取得
    public GameObject Opened;
    public GameObject Closed;
    public GameObject Book;

    //音の設定
    public AudioClip slide;
    public AudioClip closed;
    AudioSource audioSource;  

    // Start is called before the first frame update
    void Start()
    {
        Open(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void OnShelf()
    {
        if(UseItem.SelectedItem.itemtype == Item.ItemType.Key)
        {
            Open(true);
            PlayShelfOpenSound();
        }
        else
        {
            PlayShelfClosedSound();
        }
    }

    //しまってたらfalse、あいてたらtrue
    private void Open(bool which)
    {
        Opened.SetActive(which);
        Book.SetActive(which);
        Closed.SetActive(!which);
        if(which)
        {
            ItemBox.IBX.DeleteItemFromType(Item.ItemType.Key);
        }
    }

    private void PlayShelfOpenSound()
    {
        audioSource.PlayOneShot(slide, 0.7F);
    }

    private void PlayShelfClosedSound()
    {
        audioSource.PlayOneShot(closed, 0.7F);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : SingletonMonoBehaviour<SEManager>
{
    public AudioClip Do;
    public AudioClip So;
    public AudioClip Ra;
    public AudioClip GameOver;


    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlaySE(int num)
    {
        switch(num){
            case 1:
                audioSource.PlayOneShot(Do);
                break;
            case 2:
                audioSource.PlayOneShot(So);
                break;
            case 3:
                audioSource.PlayOneShot(Ra);
                break;
            case 4:
                audioSource.PlayOneShot(GameOver);
                break;
        }
    }

   
}

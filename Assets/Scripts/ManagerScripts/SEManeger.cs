using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : SingletonMonoBehaviour<SEManager>
{
    public AudioClip Do;
    public AudioClip Re;
    public AudioClip Mi;
    public AudioClip Fa;
    public AudioClip So;
    public AudioClip Ra;
    public AudioClip Si;
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
                audioSource.PlayOneShot(Re);
                break;
            case 3:
                audioSource.PlayOneShot(Mi);
                break;
            case 4:
                audioSource.PlayOneShot(Fa);
                break;
            case 5:
                audioSource.PlayOneShot(So);
                break;
            case 6:
                audioSource.PlayOneShot(Ra);
                break;
            case 7:
                audioSource.PlayOneShot(Si);
                break;
            case 8:
                audioSource.PlayOneShot(GameOver);
                break;
        }
    }

   
}

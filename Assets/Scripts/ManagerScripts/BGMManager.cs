using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : SingletonMonoBehaviour<BGMManager>
{
    private AudioSource audioSource;

    public AudioClip KiraKira;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);       
    }

    // Update is called once per frame
    public void PlayBGM(int num)
    {
        switch(num){
            case 1:
                audioSource.clip = KiraKira;
                audioSource.Play();
                break;
        }
    }
}

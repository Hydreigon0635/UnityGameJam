using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        BGMManager.Instance.PlayBGM(1);
    }
}

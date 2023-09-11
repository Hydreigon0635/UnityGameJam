using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    public int num;

    void OnCollisionEnter(Collision collision)
    {
        BallScript ballscript = collision.gameObject.GetComponent<BallScript>();
        if(ballscript.CheckFlag()){
            SEManager.Instance.PlaySE(num);
        }
        else{
            SEManager.Instance.PlaySE(4); //失敗SE
        }
    }

    public void SetNum(int num)
    {
        num = this.num;
    }
}

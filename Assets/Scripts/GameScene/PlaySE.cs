using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    public int num;
    bool check = true;

    void OnCollisionEnter(Collision collision)
    {
        BallScript ballscript = collision.gameObject.GetComponent<BallScript>();
        if(ballscript.CheckFlag() && check){
            SEManager.Instance.PlaySE(num);
        }
        else if(check){
            check = false;
        }
    }

    public void SetNum(int num)
    {
        num = this.num;
    }
}

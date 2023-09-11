using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool flag;
    private bool goal_flag;
    private Dictionary<GameObject, bool> objectFlags = new Dictionary<GameObject, bool>();
    

    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        goal_flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("接触したよ");
        //ScoreManager.Instance.AddScore(1);
        ObjScript objscript = collision.gameObject.GetComponent<ObjScript>();
        // if(objscript.CheckAngle()){
        //     Debug.Log("nullじゃないよ");
        // }
        if(collision.gameObject.CompareTag("Obj") && objscript != null){
            if(objscript.CheckAngle()){
                Debug.Log("Hit"); // ログを表示する
            }
            else{
                Debug.Log("追従を解除するよ");
                flag = false;
            }
        }
        else if(collision.gameObject.CompareTag("goal") && goal_flag){
            goal_flag = false;
            SEManager.Instance.PlaySE(9);
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity =  Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Invoke("ChangeScene", 3.0f);
        }
        
    }

    public bool CheckFlag()
    {
        return flag;
    }

    void ChangeScene()
    {
        MySceneChangeHelper.MyLoadScene(MySceneChangeHelper.MyScene.ResultScene);
    }
}

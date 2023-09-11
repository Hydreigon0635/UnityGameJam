using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        MySceneChangeHelper.MyLoadScene(MySceneChangeHelper.MyScene.TitleScene);
    }
}

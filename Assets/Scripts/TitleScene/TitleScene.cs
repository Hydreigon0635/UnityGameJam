using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Return)){
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        MySceneChangeHelper.MyLoadScene(MySceneChangeHelper.MyScene.GameScene);
    }
}

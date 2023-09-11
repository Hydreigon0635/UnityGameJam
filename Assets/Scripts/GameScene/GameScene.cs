using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene : MonoBehaviour
{
    public Transform CameraTransform;
    public Transform BallTransform;
    public Text Textobj;

    // Start is called before the first frame update
    void Start()
    {
        Textobj.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float cameraY = CameraTransform.position.y;
        float ballY = BallTransform.position.y;

        if(Input.GetKeyDown(KeyCode.Return)){
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        MySceneChangeHelper.MyLoadScene(MySceneChangeHelper.MyScene.ResultScene);
    }
}

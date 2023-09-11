using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

//シーン遷移管理クラス
static public class MySceneChangeHelper
{
    public enum MyScene { TitleScene, MenuScene, GameScene, ResultScene};
    public static MyScene scene;

    static Dictionary<string, MyScene> sceneDic = new Dictionary<string, MyScene> {
        {"TitleScene", MyScene.TitleScene},
        {"MenuScene", MyScene.MenuScene},
        {"GameScene", MyScene.GameScene},
        {"ResultScene", MyScene.ResultScene},
    };

    public static void MyLoadScene(MyScene scene)
    {
        SceneManager.LoadScene(sceneDic.FirstOrDefault(x => x.Value == scene).Key);
    }
}

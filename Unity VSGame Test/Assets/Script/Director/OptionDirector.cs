using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//機能統括スクリプト
public class OptionDirector : MonoBehaviour
{
    //よく使う機能などはここに書く
    [HideInInspector]
    public SceneChange sceneClass; //シーン移動のクラス


    // Start is called before the first frame update
    void Start()
    {
        //クラスの接続
        this.sceneClass = transform.GetComponent<SceneChange>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

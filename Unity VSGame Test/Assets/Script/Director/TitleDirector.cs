using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//タイトルでの処理を統括するスクリプト
public class TitleDirector : MonoBehaviour
{
    OptionDirector optionClass; //よく使う機能が入ったクラス


    // Start is called before the first frame update
    void Start()
    {
        this.optionClass = GameObject.Find("OptionDirector").GetComponent<OptionDirector>();

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.anyKeyDown) 
        //{ this.optionClass.sceneClass.NextScene("SelectScene"); }
    }
}

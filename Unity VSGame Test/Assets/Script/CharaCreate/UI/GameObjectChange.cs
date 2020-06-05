using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectChange : MonoBehaviour
{

    [SerializeField, Header("非Activeにしたいオブジェクトを設定する")]
    GameObject[] objOFF = null;

    [SerializeField,Header("Activeにしたいオブジェクトを設定する")]
    GameObject[] objON = null;

    //Activeのオブジェクトを変更
    public void GameObject_Change()
    {
        //Activeにする
        foreach(GameObject go in this.objON)
        {
            go.SetActive(true);
        }

        //自オブジェクトは非Activeにする
        foreach (GameObject go in this.objOFF)
        {
            go.SetActive(false);
        }
    }

}

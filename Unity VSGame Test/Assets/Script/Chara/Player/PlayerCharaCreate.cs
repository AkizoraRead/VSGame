using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//キャラ編集シーンで使われるプレイヤーの処理
public class PlayerCharaCreate : MonoBehaviour
{
    public PlayerBase playerData;   //プレイヤーの変数などのデータ

    // Start is called before the first frame update
    void Start()
    {
        this.playerData = new PlayerBase(gameObject);
        this.playerData.CharaLoad("PlayerData");    //プレイヤーのデータをロード、変数を反映
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.playerData.sprite);
    }

    //ボタン操作

    //キャラの色替え
    //赤
    public void ColorChange_Red()
    {
        this.playerData.ColorChange(new Color(1f, 0f, 0f,1f));
    }
    //青
    public void ColorChange_Blue()
    {
        this.playerData.ColorChange(new Color(0f, 0f, 1f,1f));
    }
    //緑
    public void ColorChange_Green()
    {
        this.playerData.ColorChange(new Color(0f, 1f, 0f,1f));
    }



}

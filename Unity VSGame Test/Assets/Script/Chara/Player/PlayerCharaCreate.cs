using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//キャラ編集シーンで使われるプレイヤーの処理
public class PlayerCharaCreate : MonoBehaviour
{
    public PlayerBase playerBase;   //プレイヤーの変数などのデータ

    // Start is called before the first frame update
    void Start()
    {
        this.playerBase = new PlayerBase(gameObject);
        this.playerBase.CharaLoad("PlayerData",gameObject);    //プレイヤーのデータをロード、変数を反映
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.playerBase.sprite);
    }

    //ボタン操作

    //キャラの色替え
    //赤
    public void ColorChange_Red()
    {
        this.playerBase.ColorChange(new Color(1f, 0f, 0f,1f));

        Debug.Log("色を赤に変更");
    }
    //青
    public void ColorChange_Blue()
    {
        this.playerBase.ColorChange(new Color(0f, 0f, 1f,1f));
        Debug.Log("色を青に変更");
    }
    //緑
    public void ColorChange_Green()
    {
        this.playerBase.ColorChange(new Color(0f, 1f, 0f,1f));
        Debug.Log("色を緑に変更");
    }

    //コマンドを再設定
    //Attack
    public void CommandChange_Attack(string name_)
    {
        this.playerBase.CommandChange_Attack(name_);
    }
    //Recover
    public void CommandChange_Recover(string name_)
    {
        this.playerBase.CommandChange_Recover(name_);
    }
    //Enhance
    public void CommandChange_Enhance(string name_)
    {
        this.playerBase.CommandChange_Enhance(name_);
    }

    //パラメータを再設定


    //セーブ
    public void PlayerDataSave()
    {
        this.playerBase.CharaSave("PlayerData");
    }
}

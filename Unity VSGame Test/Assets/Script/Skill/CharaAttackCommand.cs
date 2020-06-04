using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//攻撃コマンドを格納
public class CharaAttackCommand : CharaCommandBase
{

    //攻撃コマンド

    //受け取った変数によって返すコマンドを変える
    public CharaAttackCommand(string name_)
    {
        this.command = null;
        this.cName = "";


        switch (name_)
        {
            case "": this.command = AttackCommand_1; break;
        }

        this.cName = name_;

    }



    //攻撃コマンドはここに追加していく
    void AttackCommand_1()
    {



        Debug.Log("AttackCommand_1 : 実行");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//回復コマンドを格納
public class CharaRecoverCommand : CharaCommandBase
{
    //回復コマンド

    //受け取った変数によって返すコマンドを変える
    public CharaRecoverCommand(string name_)
    {
        this.command = null;
        this.cName = "";


        switch (name_)
        {
            case "": this.command = RecoverCommand_1; break;
        }

        this.cName = name_;

    }



    //回復コマンドはここに追加していく
    void RecoverCommand_1()
    {



        Debug.Log("RecoverCommand_1 : 実行");
    }
}

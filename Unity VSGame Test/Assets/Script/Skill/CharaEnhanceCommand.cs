using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//強化コマンド
public class CharaEnhanceCommand : CharaCommandBase
{
    //強化コマンド


    //受け取った変数によって返すコマンドを変える
    public CharaEnhanceCommand(string name_)
    {
        this.command = null;
        this.cName = "";


        switch (name_)
        {
            case "": command = EnhanceCommand_1; break;
        }

        this.cName = name_;

    }




    //強化コマンドはここに追加していく
    void EnhanceCommand_1()
    {



        Debug.Log("EnhanceCommand_1 : 実行");
    }
}

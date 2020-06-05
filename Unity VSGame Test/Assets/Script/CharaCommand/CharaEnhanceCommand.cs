using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//強化コマンド
public class CharaEnhanceCommand : CharaCommandBase
{
    //強化コマンド


    //--------------------------------------------------------------------------
    //受け取った変数によって返すコマンドを変える
    public CharaEnhanceCommand()
    {
        string[] str = { "1", "2", "3" };

        this.cdName = str;

        foreach (string name_ in this.cdName)
        {
            this.cData.Add(name_, CommandDataSet(name_));
        }
    }

    //--------------------------------------------------------------------------
    //コマンド処理を設定
    //引数(コマンド名)
    protected override Command CommandSet(string name_)
    {
        Command command_ = null;

        switch (name_)
        {
            case "1": command_ = EnhanceCommand_1; break;
            case "2": command_ = EnhanceCommand_2; break;
            case "3": command_ = EnhanceCommand_3; break;
            default:
                Debug.LogWarning(name_ + "というコマンドは存在しない\n自動的に1を設定します。");
                command_ = EnhanceCommand_1;
                break;
        }

        return command_;
    }

    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //強化コマンドはここに追加していく
    void EnhanceCommand_1()
    {



        Debug.Log("EnhanceCommand_1 : 実行");
    }
    void EnhanceCommand_2()
    {



        Debug.Log("EnhanceCommand_2 : 実行");
    }
    void EnhanceCommand_3()
    {



        Debug.Log("EnhanceCommand_3 : 実行");
    }
}

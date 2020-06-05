using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//回復コマンドを格納
public class CharaRecoverCommand : CharaCommandBase
{
    //回復コマンド

    //--------------------------------------------------------------------------
    //受け取った変数によって返すコマンドを変える
    public CharaRecoverCommand()
    {
        string[] str = {"1","2","3" };

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
            case "1": command_ = RecoverCommand_1; break;
            case "2": command_ = RecoverCommand_2; break;
            case "3": command_ = RecoverCommand_3; break;
            default:
                Debug.LogWarning(name_ + "というコマンドは存在しない\n自動的に1を設定します。");
                command_ = RecoverCommand_1;
                break;
        }


        return command_;
    }



    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //回復コマンドはここに追加していく
    void RecoverCommand_1()
    {



        Debug.Log("RecoverCommand_1 : 実行");
    }
    void RecoverCommand_2()
    {



        Debug.Log("RecoverCommand_2 : 実行");
    }
    void RecoverCommand_3()
    {



        Debug.Log("RecoverCommand_3 : 実行");
    }
}

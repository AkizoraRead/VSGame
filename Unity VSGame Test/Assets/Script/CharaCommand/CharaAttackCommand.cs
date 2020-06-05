using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

//攻撃コマンドを格納
public class CharaAttackCommand : CharaCommandBase
{
    //攻撃コマンド
    //--------------------------------------------------------------------------
    //受け取った変数によって返すコマンドを変える
    public CharaAttackCommand()
    {
        string[] str = { "1", "2" };

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
            case "1": command_ = AttackCommand_1; break;
            case "2": command_ = AttackCommand_2; break;
            default:
                Debug.LogWarning(name_ + "というコマンドは存在しない\n自動的に1を設定します。");
                command_ = AttackCommand_1;
                break;
        }

        return command_;
    }

    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //攻撃コマンドはここに追加していく
    void AttackCommand_1()
    {



        Debug.Log("AttackCommand_1 : 実行");
    }

    void AttackCommand_2()
    {



        Debug.Log("AttackCommand_2 : 実行");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharaCommandBase
{
    //コマンド処理
    public delegate void Command();

    //コマンドデータ
    public struct CommandData
    {
        public Command command; //関数
        public string cName;    //コマンド名
        public string[] cLog;   //コマンドの詳細
    }
    //--------------------------------------------------------------------------
    //共通変数
    protected string[] cdName;
    public Dictionary<string, CommandData> cData;
    //--------------------------------------------------------------------------
    protected CharaCommandBase()
    {
        this.cData = new Dictionary<string, CommandData>();
    }


    //コマンドデータ初期化
    protected CommandData CommandDataSet(string name_)
    {
        CommandData data_;
        data_.command = CommandSet(name_);
        data_.cName = name_;
        data_.cLog = CommandLogSet(name_);
        return data_;
    }
    //--------------------------------------------------------------------------
    //コマンド処理を設定
    //引数(コマンド名)
    protected abstract Command CommandSet(string name_);
    
    //コマンド詳細を設定
    //引数(コマンド名)
    string[] CommandLogSet(string name_)
    {
        string[] log = new string[10];
        return log;
    }

}
//--------------------------------------------------------------------------
//キャラクターのコマンド
public interface CharaCommand
{
    //選べるコマンド
    void Command1();
    void Command2();
    void Command3();
    void Damage();      //ダメージ処理
}

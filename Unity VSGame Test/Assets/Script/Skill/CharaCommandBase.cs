using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaCommandBase
{
    public delegate void Command();

    public Command command;  //関数
    public string cName;    //コマンド名
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

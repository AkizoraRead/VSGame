using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaBase
{
    //キャラクターに必要なパラメータや関数を格納しておく

    //キャラクターの種類
    protected enum CharaType
    {
        None = 0,
        Player = 1,
        Enemy = 2,
    }

    //キャラクターの行動


    //パラメータ
    //フィールド
    int hp;             //体力
    int power;          //攻撃力
    int dodgeRate;      //回避率



    //プロパティ
    //体力    
    public int Hp
    {
        get { return hp; }
        private set { this.hp = value; }
    }
    //攻撃力
    public int Power
    {
        get { return this.power; }
        private set { this.power = value; }
    }
    //回避率
    public int DodgeRate
    {
        get { return this.dodgeRate; }
        private set { this.dodgeRate = value; }
    }


    //
    //HPのセッティング
    public void SetHP(int hp_)
    {
        this.Hp = hp_;
    }
    //Powerのセッティング
    public void SetPower(int power_)
    {
        this.Power = power_;
    }
    //DodgeRateのセッティング
    public void SetDodgeRate(int dodgeRate_)
    {
        this.DodgeRate = dodgeRate_;
    }



}

//キャラクターのコマンド
public interface CharaCommand
{
    void Attack();      //攻撃
    void Recover();     //回復
    void Enhance();     //強化(バフ)

}


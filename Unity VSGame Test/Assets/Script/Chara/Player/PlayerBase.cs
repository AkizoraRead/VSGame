using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : CharaBase
{
    //プレイヤー固有のパラメータや関数
    CharaType charaType;

    public PlayerBase()
    {
        SetHP(10);
        SetPower(10);
        SetDodgeRate(10);

        this.charaType = CharaType.Player;
    }

}

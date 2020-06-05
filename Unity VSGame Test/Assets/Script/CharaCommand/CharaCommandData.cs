using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaCommandData
{
    public CharaAttackCommand  attackCommand;
    public CharaRecoverCommand recoverCommand;
    public CharaEnhanceCommand enhanceCommand;

    public CharaCommandData()
    {
        this.attackCommand = new CharaAttackCommand();
        this.recoverCommand = new CharaRecoverCommand();
        this.enhanceCommand = new CharaEnhanceCommand();
    }
}

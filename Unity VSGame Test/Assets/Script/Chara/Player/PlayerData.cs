using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour,CharaCommand
{
    public PlayerBase playerBase;

    // Start is called before the first frame update
    void Start()
    {
        this.playerBase = new PlayerBase(gameObject);
        this.playerBase.CharaLoad("PlayerData");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Command1()
    {
        this.playerBase.attack.command();
    }

    public void Command2()
    {
        this.playerBase.ColorChange(new Color(0.0f, 0.0f, 1.0f, 1.0f));
    }

    public void Command3()
    {
        this.playerBase.ColorChange(new Color(0.0f, 1.0f, 0.0f, 1.0f));
    }

    public void Damage()
    {

    }

}

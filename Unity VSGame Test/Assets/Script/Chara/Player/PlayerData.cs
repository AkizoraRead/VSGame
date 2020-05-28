using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour,CharaCommand
{
    PlayerBase playerBase;
    // Start is called before the first frame update
    void Start()
    {
        this.playerBase = new PlayerBase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
    }

    public void Recover()
    {
    }

    public void Enhance()
    {
    }


}

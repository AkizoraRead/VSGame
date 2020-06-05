using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<PlayerCharaCreate>().playerBase.CharaSave("PlayerData");
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(GetComponent<PlayerCharaCreate>().playerBase.CharaParameterLog());
                Debug.Log(GetComponent<PlayerCharaCreate>().playerBase.CharaParameter_ToJson());
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<PlayerCharaCreate>().playerBase = new PlayerBase(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<PlayerCharaCreate>().playerBase.CharaLoad("PlayerData",gameObject);
            GetComponent<PlayerCharaCreate>().playerBase.UIChange();
        }
    }


}

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
            GetComponent<PlayerCharaCreate>().playerData.CharaSave("PlayerData");
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(GetComponent<PlayerCharaCreate>().playerData.CharaParameterLog());
                Debug.Log(GetComponent<PlayerCharaCreate>().playerData.CharaParameter_ToJson());
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<PlayerCharaCreate>().playerData = new PlayerBase(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<PlayerCharaCreate>().playerData.CharaLoad("PlayerData");
            GetComponent<PlayerCharaCreate>().playerData.UIChange();
        }
    }


}

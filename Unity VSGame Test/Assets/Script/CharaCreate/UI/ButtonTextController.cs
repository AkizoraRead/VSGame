using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTextController : MonoBehaviour
{
    PlayerCharaCreate playerClass;  //プレイヤーのデータ

    //表示するテキストの種類
    enum TextType
    {
        None,
        HP,
        Power,
        DodgeRate,
        CommandAttack,
        CommandRecover,
        CommandEnhance,
    }
    [SerializeField]
    TextType type = TextType.None;

    Text buttonText;    //変えるテキスト


    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーのデータを指定
        this.playerClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCharaCreate>();

        //子要素のテキストを指定
        this.buttonText = transform.Find("Text").GetComponent<Text>();

        TextChange();
    }

    // Update is called once per frame
    void Update()
    {
        //テキストの更新
        TextChange();
    }

    //ボタンのテキスト設定
    void TextChange()
    {
        string text = "";
        switch (this.type)
        {
            case TextType.HP:               text = this.playerClass.playerBase.CharaHPLog(); break;
            case TextType.Power:            text = this.playerClass.playerBase.CharaPowerLog(); break;
            case TextType.DodgeRate:        text = this.playerClass.playerBase.CharaDodgeRateLog(); break;
            case TextType.CommandAttack:    text = this.playerClass.playerBase.CharaAttackCommandNameLog(); break;
            case TextType.CommandRecover:   text = this.playerClass.playerBase.CharaRecoverCommandNameLog(); break;
            case TextType.CommandEnhance:   text = this.playerClass.playerBase.CharaEnhanceCommandNameLog(); break;
        }
        this.buttonText.text = text;
    }
}

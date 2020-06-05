using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaBase
{
    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //キャラクターに必要なパラメータや関数を格納しておく
    //--------------------------------------------------------------------------
    //キャラクターの種類
    public enum CharaType
    {
        None = 0,
        Player = 1,
        Enemy = 2,
    }
    //コマンド


    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //フィールド
    //--------------------------------------------------------------------------
    //パラメータ
    [SerializeField] int hp;             //体力
    [SerializeField] int power;          //攻撃力
    [SerializeField] int dodgeRate;      //回避率
    [SerializeField] CharaType cType;    //キャラの種類

    public SpriteRenderer sprite;    //絵
    public Color color;              //色

    //コマンド
    CharaCommandData cDataClass;    //コマンドクラス

    [SerializeField] string attackCName;    //初期設定用　コマンドネーム
    [SerializeField] string recoverCName;   //初期設定用　コマンドネーム
    [SerializeField] string enhanceCName;   //初期設定用　コマンドネーム

    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //プロパティ
    //--------------------------------------------------------------------------
    //体力    
    public int Hp
    {
        get { return hp; }
        protected set { this.hp = value; }
    }
    //攻撃力
    public int Power
    {
        get { return this.power; }
        protected set { this.power = value; }
    }
    //回避率
    public int DodgeRate
    {
        get { return this.dodgeRate; }
        protected set { this.dodgeRate = value; }
    }
    //キャラの種類
    public CharaType CType
    {
        get { return this.cType; }
        protected set { this.cType = value; }
    }

    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //コンストラクタ
    protected CharaBase()
    {
        this.Hp = 10;
        this.Power = 10;
        this.DodgeRate = 10;
        this.cType = CharaType.None;

        this.sprite = null;
        this.color = new Color(1f, 1f, 1f, 1f);


        //コマンドセット
        this.attackCName = "1";
        this.recoverCName = "1";
        this.enhanceCName = "1";
        this.cDataClass = new CharaCommandData();
    }
    //セッティング
    //コンポーネントと変数の接続
    protected virtual void ComponentSetting(GameObject go)
    {
        this.sprite = go.GetComponent<SpriteRenderer>();
    }

    //UI
    public virtual void UIChange()
    {

    }

    //コマンド設定
    //Attack
    public void CommandChange_Attack(string name_)
    {
        this.attackCName = name_;
    }
    //Recover
    public void CommandChange_Recover(string name_)
    {
        this.recoverCName = name_;
    }

    //Enhance
    public void CommandChange_Enhance(string name_)
    {
        this.enhanceCName = name_;
    }

    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //キャラパラメータログ    stringで返す
    //--------------------------------------------------------------------------
    //全部
    public string CharaParameterLog()
    {
        string log = "";

        //パラメータを追加したらこの下に追記する

        log += CharaCTypeLog();
        log += CharaHPLog();
        log += CharaPowerLog();
        log += CharaDodgeRateLog();
        log += CharaColorLog();
        log += CharaAttackCommandNameLog();
        log += CharaRecoverCommandNameLog();
        log += CharaEnhanceCommandNameLog();

        return log;
    }
    //HP
    public string CharaHPLog()
    {
        string log = "HP:" + this.Hp.ToString() + "\n";
        return log;
    }
    //Power
    public string CharaPowerLog()
    {
        string log = "Power:" + this.Power.ToString() + "\n";
        return log;
    }
    //DodgeRate
    public string CharaDodgeRateLog()
    {
        string log = "DodgeRate:" + this.DodgeRate.ToString() + "\n";
        return log;
    }
    //CharaType
    public string CharaCTypeLog()
    {
        string log = "CharaType:" + this.cType.ToString() + "\n";
        return log;
    }
    //Color
    public string CharaColorLog()
    {
        string log = "Color:" + this.color.ToString() + "\n";
        return log;
    }
    //AttackCommandName
    public string CharaAttackCommandNameLog()
    {
        string log = "Attack:" + this.cDataClass.attackCommand.cData[this.attackCName].cName + "\n";
        return log;
    }
    //RecoverCommandName
    public string CharaRecoverCommandNameLog()
    {
        string log = "Recover:" + this.cDataClass.recoverCommand.cData[this.recoverCName].cName + "\n";
        return log;
    }
    //EnhanceCommandName
    public string CharaEnhanceCommandNameLog()
    {
        string log = "Enhance:" + this.cDataClass.enhanceCommand.cData[this.enhanceCName].cName + "\n";
        return log;
    }
    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //セーブ
    //--------------------------------------------------------------------------
    //Json形式にpublic,[SerializeField]の変数を変換
    public string CharaParameter_ToJson()
    {
        return JsonUtility.ToJson(this);
    }
    //セーブ(PlayerPrefに保存)
    //引数(格納するデータ名)
    public void CharaSave(string name)
    {
        PlayerPrefs.SetString(name, CharaParameter_ToJson());
        PlayerPrefs.Save();
        Debug.Log("保存完了");
    }

    //ロード
    public CharaBase CharaLoad(string name,GameObject go)
    {

        //nameという名のデータが保存されているか
        if(PlayerPrefs.HasKey(name))
        {
            //上書き
            var data = PlayerPrefs.GetString(name);
            JsonUtility.FromJsonOverwrite(data, this);
        }
        else
        {
            Debug.LogError(name + "という名のデータは保存されていませんでした。");
        }
        //セッティング(読み込みだけでは変わらない部分を初期化する)

        //コマンドセット
        ComponentSetting(go);   //コンポーネント
        UIChange();             //UI

        return this;
    }

}



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
    public CharaAttackCommand   attack;
    public CharaRecoverCommand  recover;
    public CharaEnhanceCommand  enhance;

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
        this.attack = new CharaAttackCommand("");

        this.recover = new CharaRecoverCommand("");

        this.enhance = new CharaEnhanceCommand("");
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
    }

    //ロード
    public CharaBase CharaLoad(string name)
    {

        //nameという名のデータが保存されているか
        if(PlayerPrefs.HasKey(name))
        {
            //上書き
            var data = PlayerPrefs.GetString(name);
            JsonUtility.FromJsonOverwrite(data, this);
            //セッティング（UIなどに反映）

        }
        else
        {
            Debug.LogError(name + "という名のデータは保存されていませんでした。");
        }

        return this;
    }

}



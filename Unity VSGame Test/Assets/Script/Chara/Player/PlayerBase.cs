using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : CharaBase
{
    //--------------------------------------------------------------------------
    //--------------------------------------------------------------------------
    //プレイヤー固有のパラメータや関数
    //--------------------------------------------------------------------------
    //コンストラクタ
    public PlayerBase(GameObject go)
    {
        //初期化
        this.CType = CharaType.Player;

        this.sprite = go.GetComponent<SpriteRenderer>();

        UIChange();
    }

    //--------------------------------------------------------------------------
    //UIなどに反映
    public virtual void UIChange()
    {
        ColorChange(this.color);
    }

    //--------------------------------------------------------------------------
    //キャラの色変更
    public void ColorChange(Color color_)
    {
        this.color = color_;
        this.sprite.color = color;
    }

    //--------------------------------------------------------------------------
    //HPバー
    public void HPBarSet(int hp_)
    {

    }

}

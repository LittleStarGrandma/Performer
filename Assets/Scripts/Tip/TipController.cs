using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipController
{
    private string nowTip="";
    private int tipType = 1;
    private int timex = 3;
    private static TipController instance = new TipController();
    public static TipController Instance => instance;
    public Action action;//tip面板结束后干的事情
    private TipController()
    {

    }
    /// <summary>
    ///  设置消失的类型，1代表不自动消失，2代表按时间消失，可以设置消失的时间
    /// </summary>
    public void SetTipType(int typex,int timex=3)
    {
        tipType = typex;
        this.timex = timex;
    }
    public int GetTipType()
    {
        return tipType;
    }
    public int GetTime()
    {
        return timex;
    }
    public void SetTip(string thisTip)
    {
        nowTip = thisTip;
    }
    public string GetTip()
    {
        return nowTip;
    }
}

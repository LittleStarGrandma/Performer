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
    public Action action;//tip��������ɵ�����
    private TipController()
    {

    }
    /// <summary>
    ///  ������ʧ�����ͣ�1�����Զ���ʧ��2����ʱ����ʧ������������ʧ��ʱ��
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

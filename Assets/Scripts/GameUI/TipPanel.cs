using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TipPanel : BasePanel
{
    public Text tip;
    private int tipType = 1;
    private float nowTime = 0;
    private float targetTime = 1;
    public override void Init()
    {
        tip.text = TipController.Instance.GetTip();
        if(TipController.Instance.GetTipType()==1)
        {
            return;
        }
        else if(TipController.Instance.GetTipType()==2)
        {
            tipType = 2;
            nowTime = 0;
            targetTime = TipController.Instance.GetTime();
        }
    }
    private void FixedUpdate()
    {
        if(tipType==2)
        {
            nowTime += Time.deltaTime;
            if(targetTime<=nowTime)
            {
                UIManager.Instance.HidePanel<TipPanel>(false);
                tipType = 3;
                TipController.Instance.action?.Invoke();
                TipController.Instance.action = null;
            }
        }
    }
}

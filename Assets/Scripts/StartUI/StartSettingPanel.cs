using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSettingPanel : BasePanel
{
    public Slider soundSlider;
    public Button returnBtn;
    public override void Init()
    {
        returnBtn.onClick.AddListener(() =>
        {
            UIManager.Instance.HidePanel<StartSettingPanel>(false);
            
        });
    }
}

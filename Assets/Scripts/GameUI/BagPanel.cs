using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagPanel : BasePanel
{
    public Button closeBtn;
    public override void Init()
    {
        closeBtn.onClick.AddListener(()=>
        {
            UIManager.Instance.HidePanel<BagPanel>();
        });
    }
}

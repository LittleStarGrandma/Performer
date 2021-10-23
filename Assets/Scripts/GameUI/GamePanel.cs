using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : BasePanel
{
    public Button pauseBtn;
    public Button bagBtn;
    public override void Init()
    {
        bagBtn.onClick.AddListener(() =>
        {
            if (UIManager.Instance.GetPanel<BagPanel>() == null)
                UIManager.Instance.ShowPanel<BagPanel>();
            else
            {
                UIManager.Instance.HidePanel<BagPanel>(false);
            }
        });
        pauseBtn.onClick.AddListener(() =>
        {
            
            UIManager.Instance.ShowPanel<PausePanel>();
          
        });
    }
}

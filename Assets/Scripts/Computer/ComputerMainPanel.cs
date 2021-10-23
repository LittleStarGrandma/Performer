using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerMainPanel : BasePanel
{
    public Button closeBtn;
    public override void Init()
    {
        closeBtn.onClick.AddListener(() =>
        {
            UIManager.Instance.HidePanel<ComputerMainPanel>();
            StoryController.Instance.SetNowItem(1, 5);
            MapController.Instance.SetMapOfNowStory();
        });
    }
}

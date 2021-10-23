using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DebugPanel : BasePanel
{
    public InputField storyID;
    public InputField partID;
    public Button sureBtn;

    public override void Init()
    {
        sureBtn.onClick.AddListener(() =>
        {
            StoryController.Instance.SetNowItem(int.Parse(storyID.text), int.Parse(partID.text));
            MapController.Instance.SetMapOfNowStory(true,true);
        });
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneMemoPanel : BasePanel
{
    public Toggle task1;
    public Toggle task2;
    public Toggle task3;
    public Text text1;
    public Text text2;
    public Text text3;

    public override void Init()
    {
        StoryItem tempItem = StoryController.Instance.GetNowItem();
        text1.text = tempItem.taskMemoOne;
        text2.text = tempItem.taskMemoTwo;
        text3.text = tempItem.taskMemoThree;
        task1.isOn = StoryController.Instance.nowTaskState1;
        task2.isOn = StoryController.Instance.nowTaskState2;
        task3.isOn = StoryController.Instance.nowTaskState3;
    }
}

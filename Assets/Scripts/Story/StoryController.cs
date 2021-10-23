using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryController
{
    private StoryItem nowItem;
    private List<StoryItem> allItems;
    private static StoryController instance = new StoryController();
    public static StoryController Instance => instance;
    public bool nowTaskState1=false;//三个任务的完成情况，手机去获取这个
    public bool nowTaskState2=false;
    public bool nowTaskState3=false;
    private StoryController()
    {
        allItems = JsonMgr.Instance.LoadData<List<StoryItem>>("StoryJson");
    }
    public StoryItem GetNowItem()
    {
        if (nowItem != null)
            return nowItem;
        return null;
    }
    public StoryItem SetNowItem(int sectionID,int partID)
    {
        nowTaskState1 = false;
        nowTaskState2 = false;
        nowTaskState3 = false;
        foreach (StoryItem item in allItems)
        {
            if(item.sectionID==sectionID&&partID==item.partID)
            {
                nowItem = item;
                return item;
            }
        }
        return null;
    }
}

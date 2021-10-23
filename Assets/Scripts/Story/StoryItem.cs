using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//遵循物体触发条件，所有条件都是，剧情功能都是有条件物体触发-》
public class StoryItem
{
    public int sectionID;
    public int partID;
    public float playerInX;
    public float playerInY;
    public int mapID;//这个是选择哪一个地图的。
    public int mapDetailID;//通过id和反射来决定使用哪一个map的哪一种状态
    //备忘录，出现在手机里的，会显示今天要做什么，暂定3个，用自动布局组件即可
    //完成一个，会更新为已完成，完成全部会跳转到新的part
    //
    public string taskMemoOne;
    public string taskMemoTwo;
    public string taskMemoThree;
    
}

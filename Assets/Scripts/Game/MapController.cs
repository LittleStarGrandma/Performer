using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private static MapController instance;
    public static MapController Instance => instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        SetMapOfNowStory(true, true);
    }
    public Transform player;
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public Transform mapDetail1;
    public Transform mapDetail2;
    public Transform mapDetail3;

    private void SetMapActive(bool m1,bool m2, bool m3)
    {
        map1.SetActive(m1);
        map2.SetActive(m2);
        map3.SetActive(m3);
    }
    private void SetMapDetail(int i,AMapStrategy aMap)
    {
        List<bool> tempListJ = aMap.FitMap();
        if(i==1)
        {
            for(int j=0;j<mapDetail1.childCount;j++)
            {
                mapDetail1.GetChild(j).gameObject.SetActive(tempListJ[j]);
                
            }
        }
        else if (i == 2)
        {
            for (int j = 0; j < mapDetail2.childCount; j++)
            {
                mapDetail2.GetChild(j).gameObject.SetActive(tempListJ[j]);
            }
        }
        else if (i == 3)
        {
            for (int j = 0; j < mapDetail3.childCount; j++)
            {
                mapDetail3.GetChild(j).gameObject.SetActive(tempListJ[j]);
            }
        }
    }
    /// <summary>
    /// 刷新地图通过现有的剧情
    /// </summary>
    /// <param name="refreshMap">是否刷新大地图</param>
    /// <param name="refreshPlayer">是否刷新角色</param>
    public void SetMapOfNowStory(bool refreshMap=false,bool refreshPlayer=false)
    {
        StoryItem tempStory = StoryController.Instance.GetNowItem();
        int childCount = 0;
        
        if (refreshPlayer==true)
        {
            player.position = new Vector3(tempStory.playerInX, tempStory.playerInY,player.position.z);
        }
        if(tempStory.mapID==1)
        {
            if(refreshMap==true)
            {
                SetMapActive(true, false, false);
            }
            childCount = mapDetail1.childCount;
        }
        else if(tempStory.mapID==2)
        {
            if (refreshMap == true)
            {
                SetMapActive(false, true, false);
            }
            childCount = mapDetail2.childCount;
        }
        else if(tempStory.mapID==3)
        {
            if (refreshMap == true)
            {
                SetMapActive(false, false, true);
            }
            childCount = mapDetail3.childCount;
        }
        SetMapDetail(tempStory.mapID, MapFactory.ProduceMapStrategy(tempStory.mapID, tempStory.mapDetailID, childCount));
    }
}

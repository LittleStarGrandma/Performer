using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotController
{
    private static PlotController instance = new PlotController();
    public static PlotController Instance => instance;

    public Dictionary<int,List<PlotItem>> allPlots;
    private PlotController() 
    {
        allPlots = new Dictionary<int, List<PlotItem>>();
        //从这里获取到instance
        List<PlotItem> tempList = JsonMgr.Instance.LoadData<List<PlotItem>>("PlotsJson");
        for(int i=0;i<tempList.Count;i++)
        {
            if(allPlots.ContainsKey(tempList[i].id))
            {
                allPlots[tempList[i].id].Add(tempList[i]);

            }
            else
            {
                allPlots.Add(tempList[i].id, new List<PlotItem>());
                i--;

            }
        }
    }

    public List<PlotItem> ReceivePlotsById(int id)
    {
        return allPlots[id];
    }
}

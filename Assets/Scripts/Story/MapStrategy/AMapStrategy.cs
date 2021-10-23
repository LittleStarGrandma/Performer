using System.Collections;
using System.Collections.Generic;

public abstract class AMapStrategy
{
    protected List<bool> mapFitList = new List<bool>();
    public AMapStrategy()
    {

    }
    public AMapStrategy(int count)
    {
        for(int i=0;i<count;i++)
        {
            mapFitList.Add(false);
        }
        Init();
    }
    public abstract void Init();
    public List<bool> FitMap()
    {
        return mapFitList;
    }
}

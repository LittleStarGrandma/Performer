using System.Collections;
using System.Collections.Generic;

public abstract class Map1Strategy : AMapStrategy
{
    public Map1Strategy()
    {
        //初始化添加一些东西。
        mapFitList.Add(false);
        mapFitList.Add(false);
        mapFitList.Add(false);
        mapFitList.Add(false);
        mapFitList.Add(false);
    }
}

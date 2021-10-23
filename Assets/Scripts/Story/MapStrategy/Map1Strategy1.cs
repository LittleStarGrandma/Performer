using System.Collections;
using System.Collections.Generic;

public class Map1Strategy1 : AMapStrategy
{
    public Map1Strategy1(int count) : base(count)
    {

    }

    public override void Init()
    {
        mapFitList[0] = true;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Strategy2 : AMapStrategy
{
    public Map1Strategy2(int count) : base(count)
    {

    }
    public override void Init()
    {
        mapFitList[0] = false;
        mapFitList[1] = true;
    }

    
}

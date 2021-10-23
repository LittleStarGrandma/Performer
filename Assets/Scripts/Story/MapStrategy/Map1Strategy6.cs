using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Strategy6 : AMapStrategy
{
    public Map1Strategy6(int count) : base(count)
    {

    }

    public override void Init()
    {
        mapFitList[5] = true;

    }
}

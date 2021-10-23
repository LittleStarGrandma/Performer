using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Strategy4 : AMapStrategy
{
    public Map1Strategy4(int count) : base(count)
    {

    }

    public override void Init()
    {
        mapFitList[3] = true;

    }
}

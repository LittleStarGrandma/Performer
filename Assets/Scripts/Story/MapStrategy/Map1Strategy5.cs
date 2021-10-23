using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Strategy5 : AMapStrategy
{
    public Map1Strategy5(int count) : base(count)
    {

    }

    public override void Init()
    {
        mapFitList[4] = true;

    }
}

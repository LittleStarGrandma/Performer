using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Strategy3 : AMapStrategy
{
    public Map1Strategy3(int count) : base(count)
    {

    }
    public override void Init()
    {
        mapFitList[2] = true;
    }
}

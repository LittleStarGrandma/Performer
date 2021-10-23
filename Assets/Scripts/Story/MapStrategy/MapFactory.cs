using System.Collections;
using System.Collections.Generic;

public static class MapFactory
{
    public static AMapStrategy ProduceMapStrategy(int map,int detail,int count)
    {
        if(map==1)
        {
            if (detail == 1)
                return new Map1Strategy1(count);
            else if (detail == 2)
                return new Map1Strategy2(count);
            else if (detail == 3)
                return new Map1Strategy3(count);
            else if (detail == 4)
                return new Map1Strategy4(count);
            else if (detail == 5)
                return new Map1Strategy5(count);
            else if (detail == 6)
                return new Map1Strategy6(count);
        }
        return null;
    }
}

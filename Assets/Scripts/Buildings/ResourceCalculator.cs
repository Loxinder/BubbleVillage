using UnityEngine;
using System.Collections;

public class ResourceCalculator : MonoBehaviour {

    public int wood2;
    public int stone2;
    public int gold2;
    public int gem2;

    public int wood3;
    public int stone3;
    public int gold3;
    public int gem3;

    public int wood4;
    public int stone4;
    public int gold4;
    public int gem4;

    public int wood5;
    public int stone5;
    public int gold5;
    public int gem5;

    public int ReturnWoodNeeded(int buildingLvl)
    {
        switch (buildingLvl)
        {
            case 1:
                return wood2;
            case 2:
                return wood3;
            case 3:
                return wood4;
            case 4:
                return wood5;
        }

        return 0;
    }

    public int ReturnStoneNeeded(int buildingLvl)
    {
        switch (buildingLvl)
        {
            case 1:
                return stone2;
            case 2:
                return stone3;
            case 3:
                return stone4;
            case 4:
                return stone5;
        }

        return 0;
    }

    public int ReturnGoldNeeded(int buildingLvl)
    {
        switch (buildingLvl)
        {
            case 1:
                return gold2;
            case 2:
                return gold3;
            case 3:
                return gold4;
            case 4:
                return gold5;
        }

        return 0;
    }

    public int ReturnGemNeeded(int buildingLvl)
    {
        switch (buildingLvl)
        {
            case 1:
                return gem2;
            case 2:
                return gem3;
            case 3:
                return gem4;
            case 4:
                return gem5;
        }

        return 0;
    }
}

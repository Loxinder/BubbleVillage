using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lumberjack : GatheringBuilding {

    void Start()
    {
        buildingLvl = PlayerData.lumberjackBuildingLevel;
        buildingSprite.SetSprite(buildingLvl);
    }

    override public void UpgradeBuildingLevel()
    {
        buildingLvl++;
        PlayerData.lumberjackBuildingLevel = buildingLvl;
    }
}

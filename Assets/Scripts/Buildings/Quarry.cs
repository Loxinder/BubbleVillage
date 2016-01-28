using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quarry : GatheringBuilding {

    void Start()
    {
        buildingLvl = PlayerData.quarryBuildingLevel;
        buildingSprite.SetSprite(buildingLvl);
    }

    override public void UpgradeBuildingLevel()
    {
        buildingLvl++;
        PlayerData.quarryBuildingLevel = buildingLvl;
    }

}

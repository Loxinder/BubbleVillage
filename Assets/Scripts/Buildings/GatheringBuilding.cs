using UnityEngine;
using System.Collections;

public class GatheringBuilding : Building {

    public string level1;
    public string level2;
    public string level3;
    public string level4;
    public string level5;



    public void StartLevel()
    {
        if (PlayerData.dwarfs >= 10)
        {
            resourcesManager.Dwarfs(-10);

            switch (buildingLvl)
            {
                case 1:
                    Application.LoadLevel(level1);
                    break;
                case 2:
                    Application.LoadLevel(level2);
                    break;
                case 3:
                    Application.LoadLevel(level3);
                    break;
                case 4:
                    Application.LoadLevel(level4);
                    break;
                case 5:
                    Application.LoadLevel(level5);
                    break;
            }
        }
    }
}

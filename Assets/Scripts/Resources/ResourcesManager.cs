using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ResourcesManager : MonoBehaviour {

    private ResourcesView resourcesView;

    void Start()
    {
        resourcesView = GetComponent<ResourcesView>();
    }

    public void Wood(int addedWood)
    {
        if ((PlayerData.wood + addedWood) <= PlayerData.woodMaximum)
        {
            PlayerData.wood = PlayerData.wood + addedWood;
        }
        else
        {
            PlayerData.wood = PlayerData.woodMaximum;
        }
        resourcesView.UpdateResourcesView();
    }

    public void Stone(int addedStone)
    {
        if ((PlayerData.stone + addedStone) <= PlayerData.stoneMaximum)
        {
            PlayerData.stone = PlayerData.stone + addedStone;
        }
        else
        {
            PlayerData.stone = PlayerData.woodMaximum;
        }
        resourcesView.UpdateResourcesView();
    }

    public void Gold(int addedGold)
    {
        if ((PlayerData.gold + addedGold) <= PlayerData.goldMaximum)
        {
            PlayerData.gold = PlayerData.gold + addedGold;
        }
        else
        {
            PlayerData.gold = PlayerData.woodMaximum;
        }
        resourcesView.UpdateResourcesView();
    }

    public void Gems(int addedGems)
    {
        if ((PlayerData.gem + addedGems) <= PlayerData.gemMaximum)
        {
            PlayerData.gem = PlayerData.gem + addedGems;
        }
        else
        {
            PlayerData.gem = PlayerData.woodMaximum;
        }
        resourcesView.UpdateResourcesView();
    }

    public void Dwarfs(int addedDwarfs)
    {
        if ((PlayerData.dwarfs + addedDwarfs) <= PlayerData.dwarfsMaximum)
        {
            PlayerData.dwarfs = PlayerData.dwarfs + addedDwarfs;
        }
        else
        {
            PlayerData.dwarfs = PlayerData.woodMaximum;
        }
        if (resourcesView != null)
            resourcesView.UpdateResourcesView();
    }

    public void Shrooms(int addedShrooms)
    {
        if ((PlayerData.shroom + addedShrooms) <= PlayerData.shroomMaximum)
        {
            PlayerData.shroom = PlayerData.dwarfs + addedShrooms;
        }
        else
        {
            PlayerData.shroom = PlayerData.woodMaximum;
        }
    }

}






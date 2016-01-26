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
        PlayerData.wood = PlayerData.wood + addedWood;
        resourcesView.UpdateResourcesView();
    }

    public void Stone(int addedStone)
    {
        PlayerData.stone = PlayerData.stone + addedStone;
        resourcesView.UpdateResourcesView();
    }

    public void Gold(int addedGold)
    {
        PlayerData.gold = PlayerData.gold + addedGold;
        resourcesView.UpdateResourcesView();
    }

    public void Gems(int addedGems)
    {
        PlayerData.gem = PlayerData.gem + addedGems;
        resourcesView.UpdateResourcesView();
    }

    public void Dwarfs(int addedDwarfs)
    {
        PlayerData.dwarfs = PlayerData.dwarfs + addedDwarfs;
        if(resourcesView != null)
            resourcesView.UpdateResourcesView();
    }

    public void Shrooms(int addedShrooms)
    {
        PlayerData.shroom = PlayerData.shroom + addedShrooms;
    }

}






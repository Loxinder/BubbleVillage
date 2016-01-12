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

    public void Stone(int addedWood)
    {
        PlayerData.stone = PlayerData.stone + addedWood;
        resourcesView.UpdateResourcesView();
    }

    public void Gold(int addedWood)
    {
        PlayerData.gold = PlayerData.gold + addedWood;
        resourcesView.UpdateResourcesView();
    }

    public void Gems(int addedWood)
    {
        PlayerData.gem = PlayerData.gem + addedWood;
        resourcesView.UpdateResourcesView();
    }

    public void Dwarfs(int addedWood)
    {
        PlayerData.dwarfs = PlayerData.dwarfs + addedWood;
    }

    public void Shrooms(int addedWood)
    {
        PlayerData.shroom = PlayerData.shroom + addedWood;
    }

}






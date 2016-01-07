using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ResourcesManager : MonoBehaviour {

    public void Wood(int addedWood)
    {
        PlayerData.wood = PlayerData.wood + addedWood;
        Debug.Log(PlayerData.wood);
    }

    public void Stone(int addedWood)
    {
        PlayerData.stone = PlayerData.stone + addedWood;
    }

    public void Gold(int addedWood)
    {
        PlayerData.gold = PlayerData.gold + addedWood;
    }

    public void Gems(int addedWood)
    {
        PlayerData.gem = PlayerData.gem + addedWood;
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






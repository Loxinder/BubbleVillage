using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Saver : MonoBehaviour {

    public static Saver saver;

   void Awake()
   {
        DontDestroyOnLoad(gameObject);
    }

  public void Save()
   {
       BinaryFormatter binaryFormatter = new BinaryFormatter();
       FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
       PlayerSaveData data = new PlayerSaveData();

       binaryFormatter.Serialize(file, data);
       file.Close();
   }

    void OnApplicationQuit()
    {
        Save();
    }

}

[Serializable]
public class PlayerSaveData
{
    public int wood = PlayerData.wood;
    public int stone = PlayerData.stone;
    public int gold = PlayerData.gold;
    public int gem = PlayerData.gem;
    public int schroom = PlayerData.shroom;
    public int dwarfs = PlayerData.dwarfs;
    public int lubmerjackBuildingLevel = PlayerData.lumberjackBuildingLevel;
    public int quarryBuildingLevel = PlayerData.quarryBuildingLevel;
}



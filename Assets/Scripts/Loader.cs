using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Loader : MonoBehaviour {

    void Start()
    {
        Load();
    }


    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerSaveData data = (PlayerSaveData)binaryFormatter.Deserialize(file);
            file.Close();

            PlayerData.wood = data.wood;
            PlayerData.stone = data.stone;
            PlayerData.gold = data.gold;
            PlayerData.gem = data.gem;
            PlayerData.shroom = data.schroom;
            PlayerData.dwarfs = data.dwarfs;

            Debug.Log("Loader operational");
        }
    }
}

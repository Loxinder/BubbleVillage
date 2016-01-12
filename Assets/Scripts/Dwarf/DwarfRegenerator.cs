using UnityEngine;
using System;
using System.Collections;

public class DwarfRegenerator : MonoBehaviour {

    DateTime currentDate;
    DateTime oldDate;
    public static DwarfRegenerator regenerator;

    void Awake()
    {
        if (regenerator == null)
        {
            DontDestroyOnLoad(gameObject);
            regenerator = this;
        }
        else if (regenerator != this)
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        //Store the current time when it starts
        currentDate = System.DateTime.Now;

        //Grab the old time from the player prefs as a long
        long temp = Convert.ToInt64(PlayerPrefs.GetString("sysString"));

        //Convert the old time from binary to a DataTime variable
        DateTime oldDate = DateTime.FromBinary(temp);
        Debug.Log("oldDate: " + oldDate);

        //Use the Subtract method and store the result as a timespan variable
        TimeSpan difference = currentDate.Subtract(oldDate);
        Debug.Log("Difference: " + difference);

    }

    void OnApplicationQuit()
    {
        //Savee the current system time as a string in the player prefs class
        PlayerPrefs.SetString("sysString", System.DateTime.Now.ToBinary().ToString());

        Debug.Log("Saving this date to prefs: " + System.DateTime.Now);
    }
}

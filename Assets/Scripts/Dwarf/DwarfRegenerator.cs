using UnityEngine;
using System;
using System.Collections;

public class DwarfRegenerator : MonoBehaviour {

    DateTime currentDate;
    DateTime oldDate;
    TimeSpan difference;

    public static DwarfRegenerator regenerator;
    private ResourcesManager resourcesManager;



    private int actualRegenerateTimer;

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

    void OnLevelWasLoaded()
    {
       resourcesManager = GameObject.FindObjectOfType<ResourcesManager>();
    }

    void Start()
    {
        resourcesManager = GameObject.FindObjectOfType<ResourcesManager>();

        CalculateDifferenceInTimeSinceLastQuit();

        double differenceInSeconds = difference.TotalSeconds;
        int dwarfsRegeneratedWhenOut = (int)(differenceInSeconds / 3);

        resourcesManager.Dwarfs(dwarfsRegeneratedWhenOut);

        double restFromDifference = differenceInSeconds % 3;

        actualRegenerateTimer = (int) restFromDifference;

        StartCoroutine(addDwarf()); 
    }

   

    IEnumerator addDwarf()
    {
        while (true)
        {
            if (actualRegenerateTimer >= 3)
            {
                resourcesManager.Dwarfs(1);
                actualRegenerateTimer = 0;
                yield return null;
            }
            else
            {
                actualRegenerateTimer += 1;
                yield return new WaitForSeconds(1);
            }
        }
    }

    void CalculateDifferenceInTimeSinceLastQuit()
    {
        //Store the current time when it starts
        currentDate = System.DateTime.Now;

        //Grab the old time from the player prefs as a long
        long temp = Convert.ToInt64(PlayerPrefs.GetString("sysString"));

        //Convert the old time from binary to a DataTime variable
        DateTime oldDate = DateTime.FromBinary(temp);
        Debug.Log("oldDate: " + oldDate);

        //Use the Subtract method and store the result as a timespan variable
        difference = currentDate.Subtract(oldDate);
    }



    void OnApplicationQuit()
    {
        //Savee the current system time as a string in the player prefs class
        PlayerPrefs.SetString("sysString", System.DateTime.Now.ToBinary().ToString());

        Debug.Log("Saving this date to prefs: " + System.DateTime.Now);
    }
}

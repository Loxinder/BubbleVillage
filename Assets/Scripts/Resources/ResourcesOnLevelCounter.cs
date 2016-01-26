using UnityEngine;
using System.Collections;

public class ResourcesOnLevelCounter : MonoBehaviour {

    private int resourcesOnLevel;

    public GameObject endPanel;

    public void ResourceRemoved()
    {
        resourcesOnLevel--;
        Debug.Log(resourcesOnLevel);

        if (resourcesOnLevel <= 0)
        {
            endPanel.SetActive(true);
        }
    }

    public void AddResourceToCounter()
    {
        resourcesOnLevel++;
        Debug.Log(resourcesOnLevel);
    }
}

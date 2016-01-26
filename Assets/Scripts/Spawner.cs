using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public bool isResource;

    public GameObject prefabOne;
    public GameObject prefabTwo;
    public GameObject prefabThree;

    [Range(0, 1)]
    public float prefabOneChance;
    [Range(0, 1)]
    public float prefabTwoChance;
    [Range(0, 1)]
    public float prefabThreeChance;

    //For script calculation
    private float prefabOneCalculation;
    private float prefabTwoCalculation;
    private float prefabThreeCalculation;

    private ResourcesOnLevelCounter resourcesOnLevelCounter;

    void Start()
    {
        resourcesOnLevelCounter = GameObject.FindObjectOfType<ResourcesOnLevelCounter>();

        float randomNumber = Random.value;
        prefabTwoCalculation = prefabOneChance + prefabTwoChance;
        if (prefabTwoCalculation > 1) { Debug.Log("Random chances set wrong!"); }
        prefabThreeCalculation = prefabTwoCalculation + prefabThreeChance;
        if (prefabThreeCalculation > 1) { Debug.Log("Random chances set wrong!"); }

        SpawnPrefab(randomNumber, prefabOneChance, prefabTwoCalculation, prefabThreeChance);
    }

    //Handles actual spawning
    void SpawnPrefab(float randomNumber, float prefabOneChance, float prefabTwoChance, float prefabThreeChance)
    {
        if (prefabOneChance > randomNumber)
        {
            GameObject prefab = (GameObject)Instantiate(prefabOne, GetPosition(), Quaternion.identity);
            if (isResource)
                resourcesOnLevelCounter.AddResourceToCounter();
        }
        else if (prefabTwoChance > randomNumber)
        {
            GameObject prefab = (GameObject)Instantiate(prefabTwo, GetPosition(), Quaternion.identity);
            if (isResource)
                resourcesOnLevelCounter.AddResourceToCounter();
        }
        else if (prefabThreeChance > randomNumber)
        {
            GameObject prefab = (GameObject)Instantiate(prefabThree, GetPosition(), Quaternion.identity);
            if (isResource)
                resourcesOnLevelCounter.AddResourceToCounter();
        }

    }

    //Makes shure that object is placed in spawner position
    Vector2 GetPosition()
    {
        Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y);
        return spawnPosition;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 1, 1, 0.5F);
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}

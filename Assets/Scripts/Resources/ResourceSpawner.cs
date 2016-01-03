using UnityEngine;
using System.Collections;

public class ResourceSpawner : MonoBehaviour {

    public GameObject resourceOne;
    public GameObject resourceTwo;
    public GameObject resourceThree;

    [Range(0, 1)]
    public float resourceOneChance;
    [Range(0, 1)]
    public float resourceTwoChance;
    [Range(0, 1)]
    public float resourceThreeChance;

    //For script calculation
    private float resourceOneCalculation;
    private float resourceTwoCalculation;
    private float resourceThreeCalculation;
    
    void Start () {
        
        float randomNumber = Random.value;
        resourceTwoCalculation = resourceOneChance + resourceTwoChance;
        if (resourceTwoCalculation > 1) { Debug.Log("Random chances set wrong!"); }
        resourceThreeCalculation = resourceTwoCalculation + resourceThreeChance;
        if (resourceThreeCalculation > 1) { Debug.Log("Random chances set wrong!"); }

        SpawnResource(randomNumber, resourceOneChance, resourceTwoCalculation, resourceThreeChance);
	}
	
    //Handles actual spawning
    void SpawnResource (float rNumber, float resOne, float resTwo, float resThree)
    {
        if (resOne > rNumber)
        {
            GameObject resource = (GameObject)Instantiate(resourceOne, SetPosition(), Quaternion.identity);
        }
        else if (resTwo > rNumber)
        {
            GameObject resource = (GameObject)Instantiate(resourceTwo, SetPosition(), Quaternion.identity);
        }
        else if (resThree > rNumber)
        {
            GameObject resource = (GameObject)Instantiate(resourceThree, SetPosition(), Quaternion.identity);
        }
       
    }

    //Makes shure that object is placed in spawner position
    Vector2 SetPosition()
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

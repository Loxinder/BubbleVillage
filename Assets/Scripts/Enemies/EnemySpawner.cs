using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyOne;
    public GameObject enemyTwo;
    public GameObject enemyThree;

    [Range(0, 1)]
    public float enemyOneChance;
    [Range(0, 1)]
    public float enemyTwoChance;
    [Range(0, 1)]
    public float enemyThreeChance;

    //For script calculation
    private float enemyOneCalculation;
    private float enemyTwoCalculation;
    private float enemyThreeCalculation;
    
    void Start () {
        
        float randomNumber = Random.value;
        enemyTwoCalculation = enemyOneChance + enemyTwoChance;
        if (enemyTwoCalculation > 1) { Debug.Log("Random chances set wrong!"); }
        enemyThreeCalculation = enemyTwoCalculation + enemyThreeChance;
        if (enemyThreeCalculation > 1) { Debug.Log("Random chances set wrong!"); }

        SpawnResource(randomNumber, enemyOneChance, enemyTwoCalculation, enemyThreeChance);
	}
	
    //Handles actual spawning
    void SpawnResource (float rNumber, float resOne, float resTwo, float resThree)
    {
        if (resOne > rNumber)
        {
            GameObject enemy = (GameObject)Instantiate(enemyOne, SetPosition(), Quaternion.identity);
        }
        else if (resTwo > rNumber)
        {
            GameObject enemy = (GameObject)Instantiate(enemyTwo, SetPosition(), Quaternion.identity);
        }
        else if (resThree > rNumber)
        {
            GameObject enemy = (GameObject)Instantiate(enemyThree, SetPosition(), Quaternion.identity);
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
        Gizmos.color = new Color(1, 0, 0, 0.5F);
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}

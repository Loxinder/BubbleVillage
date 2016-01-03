using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public int rows;
    public int columns;
    private int rowDistance;
    private int columnDistance;
    private int widthSpawnPoint;
    private int heightSpawnPoint;

    public GameObject placeholder;

    // Use this for initialization
    void Start () {

        columnDistance = Screen.width / columns;
        rowDistance = Screen.height / (rows*2);

        widthSpawnPoint = 50;

        for (int i = 1; i <= columns; i++)
        {
            heightSpawnPoint = Screen.height - 50;

            for (int j = 1; j <= rows; j++)
            {
                heightSpawnPoint = heightSpawnPoint - rowDistance;
                SpawnObject(widthSpawnPoint, heightSpawnPoint);
            }

            widthSpawnPoint = widthSpawnPoint + columnDistance;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnObject(int width, int height)
    {
        Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector2(width, height));
        GameObject projectile = (GameObject)Instantiate(placeholder, spawnPosition, Quaternion.identity);
    }
}

using UnityEngine;
using System.Collections;

public class RockHit : MonoBehaviour {

    public static int stone;
    private DwarfShooter dwarfShooter;

    public int material = 10;

	// Use this for initialization
	void Start () {
        dwarfShooter = GameObject.FindObjectOfType<DwarfShooter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        Resources.stone = Resources.stone + material;

        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        Destroy(gameObject);
    }


}

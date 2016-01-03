using UnityEngine;
using System.Collections;

public class GoldHit : MonoBehaviour {

    public static int gold;
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
        Resources.gold = Resources.gold + material;

        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        Destroy(gameObject);
    }


}

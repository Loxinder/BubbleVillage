using UnityEngine;
using System.Collections;

public class ShroomHit : MonoBehaviour {

    public static int shroom;
    private DwarfShooter dwarfShooter;

    public int material = 1;

	// Use this for initialization
	void Start () {
        dwarfShooter = GameObject.FindObjectOfType<DwarfShooter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        Resources.shroom = Resources.shroom + material;

        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        Destroy(gameObject);
    }


}

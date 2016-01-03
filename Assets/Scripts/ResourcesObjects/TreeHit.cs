using UnityEngine;
using System.Collections;

public class TreeHit : MonoBehaviour {

    public static int wood;
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
        Resources.wood = Resources.wood + material;

        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        Destroy(gameObject);
    }


}

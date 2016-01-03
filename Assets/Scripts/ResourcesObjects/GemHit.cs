using UnityEngine;
using System.Collections;

public class GemHit : MonoBehaviour {

    public static int gem;
    private DwarfShooter dwarfShooter;

    public int material = 1;

	void Start () {
        dwarfShooter = GameObject.FindObjectOfType<DwarfShooter>();
	}
	
    void OnCollisionEnter2D (Collision2D col)
    {
        Resources.gem = Resources.gem + material;

        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        Destroy(gameObject);
    }


}

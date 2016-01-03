using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int hitpoints;

    private DwarfShooter dwarfShooter;


    // Use this for initialization
    void Start () {
        dwarfShooter = GameObject.FindObjectOfType<DwarfShooter>();
    }
	
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        hitpoints--;
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}

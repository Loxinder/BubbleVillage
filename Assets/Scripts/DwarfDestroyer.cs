using UnityEngine;
using System.Collections;

public class DwarfDestroyer : MonoBehaviour {

    private DwarfShooter dwarfShooter;

    void Start()
    {
        dwarfShooter = GameObject.FindObjectOfType<DwarfShooter>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
    }
}

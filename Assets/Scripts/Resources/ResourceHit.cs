using UnityEngine;
using System.Collections;

public class ResourceHit : MonoBehaviour {

    public static int wood;
    private DwarfShooter dwarfShooter;
    private ResourcesManager resourcesManager;

    public string materialType;
    public int material = 10;

    void Start()
    {
        dwarfShooter = GameObject.FindObjectOfType<DwarfShooter>();
        resourcesManager = GameObject.FindObjectOfType<ResourcesManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        switch (materialType)
        {
            case "wood":
                resourcesManager.Wood(material);
                break;
            case "stone":
                resourcesManager.Stone(material);
                break;
            case "gold":
                resourcesManager.Gold(material);
                break;
            case "gems":
                resourcesManager.Gems(material);
                break;
            case "schrooms":
                resourcesManager.Shrooms(material);
                break;
            default:
                Debug.Log("No material assigned");
                break;
        }

        Destroy(col.gameObject);
        dwarfShooter.DwarfDead();
        Destroy(gameObject);
    }
}

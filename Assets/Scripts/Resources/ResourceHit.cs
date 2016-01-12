using UnityEngine;
using System.Collections;

public class ResourceHit : MonoBehaviour {

    private DwarfShooter dwarfShooter;
    private ResourcesManager resourcesManager;

    public enum Material { Wood, Stone, Gold, Gems, Schrooms };

    public Material materialType;
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
            case Material.Wood:
                resourcesManager.Wood(material);
                break;
            case Material.Stone:
                resourcesManager.Stone(material);
                break;
            case Material.Gold:
                resourcesManager.Gold(material);
                break;
            case Material.Gems:
                resourcesManager.Gems(material);
                break;
            case Material.Schrooms:
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

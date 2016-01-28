using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingSprite : MonoBehaviour {

    public Sprite Level0;
    public Sprite Level1;
    public Sprite Level2;

    private Image imageForSwapping;

    public Building building;

	void Start () {
        SetSprite(building.buildingLvl);
	}
	
    public void SetSprite(int buildingLevel)
    {
        imageForSwapping = gameObject.GetComponent<Image>();
        if (buildingLevel == 1)
        {
            imageForSwapping.sprite = Level0;
        }
        else if (buildingLevel == 2)
        {
            imageForSwapping.sprite = Level1;
        }
        else if(buildingLevel == 3)
        {
            imageForSwapping.sprite = Level2;
        }
    }
}

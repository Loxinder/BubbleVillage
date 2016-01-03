using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lumberjack : MonoBehaviour {

    public int buildingLvl;
    private int woodToUpgrade;
    private int stoneToUpgrade;
    private int goldToUpgrade;
    private int gemToUpgrade;

    public Text buildingLvlText;
    public Text woodToUpgradeText;
    public Text stoneToUpgradeText;
    public Text goldToUpgradeText;
    public Text gemToUpgradeText;

    public ResourceCalculator resourceCalculator;

    // Use this for initialization
    void Start () {
        CalculateResources();
        DisplayResources();
    }

    public void Upgrade()
    {
        if ((Resources.wood >= woodToUpgrade) && (Resources.stone >= stoneToUpgrade) && (Resources.gold >= goldToUpgrade) && (Resources.gem >= gemToUpgrade))
        {
            Resources.wood = Resources.wood - woodToUpgrade;
            Resources.stone = Resources.stone - stoneToUpgrade;
            Resources.gold = Resources.gold - goldToUpgrade;
            Resources.gem = Resources.gem - gemToUpgrade;
            buildingLvl++;
            CalculateResources();
            DisplayResources();
        }
         
    }

    void CalculateResources()
    {
        woodToUpgrade = resourceCalculator.ReturnWoodNeeded(buildingLvl);
        stoneToUpgrade = resourceCalculator.ReturnStoneNeeded(buildingLvl);
        goldToUpgrade = resourceCalculator.ReturnGoldNeeded(buildingLvl);
        gemToUpgrade = resourceCalculator.ReturnGemNeeded(buildingLvl);
    }

    void DisplayResources()
    {
        buildingLvlText.text = buildingLvl.ToString();
        woodToUpgradeText.text = woodToUpgrade.ToString();
        stoneToUpgradeText.text = stoneToUpgrade.ToString();
        goldToUpgradeText.text = goldToUpgrade.ToString();
        gemToUpgradeText.text = gemToUpgrade.ToString();

    }


}

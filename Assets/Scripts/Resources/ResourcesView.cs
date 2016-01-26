using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourcesView : MonoBehaviour {

    public Text stoneText;
    public Text woodText;
    public Text goldText;
    public Text diamondsText;
    public Text dwarfsText;

    void Start()
    {
        UpdateResourcesView();
    }
    
    public void UpdateResourcesView()
    {
        stoneText.text = PlayerData.stone.ToString();
        woodText.text = PlayerData.wood.ToString();
        goldText.text = PlayerData.gold.ToString();
        diamondsText.text = PlayerData.gem.ToString();
        if (dwarfsText != null)
        dwarfsText.text = PlayerData.dwarfs.ToString();
    }
}

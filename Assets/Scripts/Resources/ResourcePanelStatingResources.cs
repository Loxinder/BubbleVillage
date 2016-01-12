using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourcePanelStatingResources : MonoBehaviour {

    public Text woodText;
    public Text stoneText;
    public Text goldText;
    public Text diamondsText;

    void Start () {
        woodText.text = PlayerData.wood.ToString();
        stoneText.text = PlayerData.stone.ToString();
        goldText.text = PlayerData.gold.ToString();
        diamondsText.text = PlayerData.gem.ToString();
    }

}

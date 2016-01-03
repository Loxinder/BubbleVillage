using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Resources : MonoBehaviour {

    //static Resources instance = null;

    public static int wood;
    public static int stone;
    public static int gold;
    public static int gem;
    public static int shroom;
    public static int dwarfs = 10;

    public Text stoneText;
    public Text woodText;
    public Text goldText;
    public Text diamondsText;


	
	// Update is called once per frame
	void Update () {
        stoneText.text = stone.ToString();
        woodText.text = wood.ToString();
        goldText.text = gold.ToString();
        diamondsText.text = gem.ToString();
	}
}

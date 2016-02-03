using UnityEngine;
using System.Collections;

public class BuildingPanelManager : MonoBehaviour {

    public GameObject quarryPanel;
    public GameObject lumberjackPanel;
    public GameObject closePanelsPanel;

	public void CloseAllPanels()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void OpenLuberjackPanel()
    {
        lumberjackPanel.SetActive(true);
        closePanelsPanel.SetActive(true);
    }

    public void OpenQuyarryPanel()
    {
        quarryPanel.SetActive(true);
        closePanelsPanel.SetActive(true);
    }
}

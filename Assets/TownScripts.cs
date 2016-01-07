using UnityEngine;
using System.Collections;

public class TownScripts : MonoBehaviour
{

    private Saver saver;

    // Use this for initialization
    void Start()
    {
        saver = GameObject.FindObjectOfType<Saver>();

       // saver.Save();
    }
}

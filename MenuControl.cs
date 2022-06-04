using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject menuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeCanvas()
    {
        menuCanvas.SetActive(false);
        GameFlow.gameStateToInGame();
        Debug.Log("1");
    }
}

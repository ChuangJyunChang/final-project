using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public int timer = 5;
    public GameObject conclusionPanel;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("timerCalc", 1, 1);
        StartCoroutine("timerCalc");
    }


    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = "0" + timer + "";
    }

    IEnumerator timerCalc()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(1);
            timer--;
            if(timer == 0)
            {
                GameFlow.gameStateToConclusion();
                conclusionPanel.SetActive(true);
                Debug.Log("times up");
                break;
            }
        }

    }
}

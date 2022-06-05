using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public int timer = 5;
    public GameObject conclusionPanel;
    public GameObject colaEffect0;
    public GameObject colaEffect1;
    public GameObject colaEffect2;
    // Start is called before the first frame update
    void Start()
    {
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
                colaEffect0.SetActive(true);
                colaEffect1.SetActive(true);
                colaEffect2.SetActive(true);
                StartCoroutine("turnOnConclusion");
                break;
            }
        }

    }
    IEnumerator turnOnConclusion()
    {
        yield return new WaitForSecondsRealtime(2);
        GameFlow.gameStateToConclusion();
        conclusionPanel.SetActive(true);
    }
}

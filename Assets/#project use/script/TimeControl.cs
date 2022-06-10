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
        if(timer == 0)
        {

            this.GetComponent<Text>().text = "Time's up";
        }
        else
        {
            this.GetComponent<Text>().text = "0" + timer + "";
        }
    }

    IEnumerator timerCalc()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(1);
            timer--;
            if(timer == 0)
            {
                colaEffect0.GetComponent<colaControl>().enabled = true;
                colaEffect1.GetComponent<colaControl>().enabled = true;
                colaEffect2.GetComponent<colaControl>().enabled = true;
                colaEffect0.GetComponent<Animator>().enabled = false;
                colaEffect1.GetComponent<Animator>().enabled = false;
                colaEffect2.GetComponent<Animator>().enabled = false;
                StartCoroutine("turnOnConclusion");
                break;
            }
        }

    }
    IEnumerator turnOnConclusion()
    {
        GameFlow.gameStateToConclusion();
        yield return new WaitForSecondsRealtime(5);
        conclusionPanel.SetActive(true);
    }
}

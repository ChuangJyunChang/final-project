using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colaControl : MonoBehaviour
{
    public GameObject shakeLessThanFive;
    public GameObject shakeLessThanTen;
    public GameObject shakeLessThanFifteen;
    public GameObject shakeLessThanTwenty;
    public GameObject shakeLessThanTwentyFive;
    public GameObject shakeLessThanThirty;
    public GameObject shakeLessThanThirtyFive;
    public int playerId;

    // Start is called before the first frame update
    void Start()
    {
        setColaEffect();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setColaEffect()
    {
        if(playerId == 0)
        {
            if (AvatorScript.shakeTimes < 5)
            {
                //Debug.Log("5");
                Instantiate(shakeLessThanFive, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.shakeTimes < 10)
            {
                Instantiate(shakeLessThanTen, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanTen.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.shakeTimes < 15)
            {
                Instantiate(shakeLessThanFifteen, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanFifteen.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.shakeTimes < 20)
            {
                Instantiate(shakeLessThanTwenty, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanTwenty.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.shakeTimes < 25)
            {
                Instantiate(shakeLessThanTwentyFive, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.shakeTimes < 30)
            {
                Instantiate(shakeLessThanThirty, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.shakeTimes > 30)
            {
                Instantiate(shakeLessThanThirtyFive, new Vector3(-0.25f, 0.65f, -0.13f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
        }
        else if(playerId == 1)
        {
            if (AvatorScript.blackShakeTimes < 5)
            {
                Instantiate(shakeLessThanFive, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.blackShakeTimes < 10)
            {
                Instantiate(shakeLessThanTen, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanTen.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.blackShakeTimes < 15)
            {
                Instantiate(shakeLessThanFifteen, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanFifteen.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.blackShakeTimes < 20)
            {
                Instantiate(shakeLessThanTwenty, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanTwenty.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.blackShakeTimes < 25)
            {
                Instantiate(shakeLessThanTwentyFive, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.blackShakeTimes < 30)
            {
                Instantiate(shakeLessThanThirty, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.blackShakeTimes > 30)
            {
                Instantiate(shakeLessThanThirtyFive, new Vector3(1.24f, 0.65f, -0.24f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
        }
        else if(playerId == 2)
        {
            if (AvatorScript.whiteShakeTimes < 5)
            {
                Instantiate(shakeLessThanFive, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.whiteShakeTimes < 10)
            {
                Instantiate(shakeLessThanTen, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanTen.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.whiteShakeTimes < 15)
            {
                Instantiate(shakeLessThanFifteen, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanFifteen.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.whiteShakeTimes < 20)
            {
                Instantiate(shakeLessThanTwenty, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanTwenty.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.whiteShakeTimes < 25)
            {
                Instantiate(shakeLessThanTwentyFive, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.whiteShakeTimes < 30)
            {
                Instantiate(shakeLessThanThirty, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
            else if (AvatorScript.whiteShakeTimes > 30)
            {
                Instantiate(shakeLessThanThirtyFive, new Vector3(-1.76f, 0.65f, -0.13f), shakeLessThanTwentyFive.transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            }
        }
    }
}

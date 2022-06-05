using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colaControl : MonoBehaviour
{
    public int shakeTimes = 2;
    public GameObject shakeLessThanFive;
    public GameObject shakeLessThanTen;
    public GameObject shakeLessThanFifteen;
    public GameObject shakeLessThanTwenty;
    public GameObject shakeLessThanTwentyFive;
    public GameObject shakeLessThanThirty;
    public GameObject shakeLessThanThirtyFive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setColaEffect();
    }
    public void setColaEffect()
    {
        if(shakeTimes < 5)
        {
            Debug.Log("5");
            Instantiate(shakeLessThanFive, new Vector3(0.625f, 0.19f, 0.285f), new Quaternion(0, 0, 0, 0));
        }
    }
}

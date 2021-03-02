using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    private int point = 0;
    private GameObject Points;
    // Start is called before the first frame update
    void Start()
    {
      this.Points = GameObject.Find("PointsText");
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        { point += 5; }

        else if (tag == "LargeStarTag")
        { point += 15; }

        else if (tag == "SmallCloudTag")
        { point += 7; }

        else if (tag == "LargeCloudTag")
        { point += 21; }

        Points.GetComponent<Text>().text = "" + point;
    }
}


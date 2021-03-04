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
    void OnCollisionEnter(Collision collision)
    {
        if ("SmallStarTag" == collision.gameObject.tag)
        { point += 5; }

        else if ("LargeStarTag" ==  collision.gameObject.tag)
        { point += 15; }

        else if ("SmallCloudTag" == collision.gameObject.tag)
        { point += 7; }

        else if ("LargeCloudTag" == collision.gameObject.tag)
        { point += 21; }

        Points.GetComponent<Text>().text = "" + point;
    }
}


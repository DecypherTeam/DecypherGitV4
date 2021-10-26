using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolDest : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            if (pivotPoint == 5)
            {
                pivotPoint = 0;
            }

            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(-5.09f, 1.42f, 10.52f);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-13.26f, 1.6f, 12.63f);
                pivotPoint = 4;
            }

            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-15.51f, 1.53f, 4.53f);
                pivotPoint = 3;
            }

            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(1, 1.51f, 12.73f);
                pivotPoint = 2;
            }

            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(10.29f, 1.58f, 15.18f);
                pivotPoint = 1;
            }
        }
    }
}

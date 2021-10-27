using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitChildAmount : MonoBehaviour
{
    public int maxChildAmount = 1;
    
    void Update()
    {
        maxChildAmount = transform.childCount;
        if (maxChildAmount > 1)
        {
            transform.DetachChildren();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Examples
{
    public class Game : MonoBehaviour
    {
        public GameObject targetPrefab;

        public bool targetIsActive;

        private void Update()
        {
            targetPrefab = GameObject.Find("Chillie Crop(Clone)");

            if (targetPrefab)
            {
                Debug.Log("Target is active");
                targetIsActive = true;
            }
            else
            {
                Debug.Log("Target is not active");
            }
        }
    }
}


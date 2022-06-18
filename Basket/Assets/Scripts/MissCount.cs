using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissCount : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "apple")
        {
            gameManager.appleMissCount++;
        }
    }
}

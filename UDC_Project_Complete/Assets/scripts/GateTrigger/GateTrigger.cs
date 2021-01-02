﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GateLiftUpEvent.thisGateLiftUpEvent.FinishLineCrossed();
        }
    }
}

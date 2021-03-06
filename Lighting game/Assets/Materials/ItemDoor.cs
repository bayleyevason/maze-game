﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDoor : MonoBehaviour
{

    public int totalGems;


    bool canWin = false;
    public Text NoGems,Interact;

    public GameObject Door;
    private void Start()
    {
        NoGems.enabled = false;
        Interact.enabled = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        canWin = (ScoringSystem.theScore == totalGems);

        Interact.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Interact.enabled = false;
            if (canWin) 
            {
                Destroy(Door);
                Destroy(gameObject);
            }
            else { NoGems.enabled = true; }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        NoGems.enabled = false;
        Interact.enabled = false;
    }


}

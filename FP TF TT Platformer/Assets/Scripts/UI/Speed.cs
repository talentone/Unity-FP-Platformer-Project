﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public GameObject player;

    public Text speed;

	// Use this for initialization
	void Start ()
    {

	}
	
    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

	// Update is called once per frame
	void Update ()
    {
        if (player == null)
        {
            FindPlayer();
        }
        else
        {
            speed.text = "" + player.GetComponent<CharacterControls>().GetXZMag();
        }
	}
}

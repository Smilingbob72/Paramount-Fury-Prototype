﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class furyDrop: MonoBehaviour {

	public float furyamount = 5;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CJC_HinezController player = other.GetComponent<CJC_HinezController>();
            if (player != null && player.furybar < 100)
            {
				player.furybar += furyamount;
                Destroy(gameObject, .1f);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ShowRewardScript : MonoBehaviour
{
     public TextMeshProUGUI showRewards;
     public TextMeshProUGUI showRewards1;
     public TextMeshProUGUI showRewards2;

    RandomRewards _randomRewards;
    void Start()
    {
        showRewards.text = String.Empty;
        showRewards1.text = String.Empty;
        showRewards2.text = String.Empty; 
        _randomRewards = GetComponent<RandomRewards>();
    }
    
    
    void OnTriggerEnter2D(Collider2D other) //>> It collide but does not make any actions e.c Show the values of the bags <<
    {
        if (other.tag == "Bag")
        {
            showRewards.text = _randomRewards.RandomMethodCollector().ToString();
        }
        else if(other.tag == "Bag1")
        {
           showRewards1.text = _randomRewards.RandomMethodCollector().ToString();
        } 
        else if (other.tag == "Bag2")
        {
            showRewards2.text = _randomRewards.RandomMethodCollector().ToString();
        }
    }
    
}


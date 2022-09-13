using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLosingRewards : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Arrow")
        {
            Debug.Log("Collide with square");
            other.GetComponentInChildren<RandomRewards>().AppendTheLosingRewards();
            
        }
    }
}

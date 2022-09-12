using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawnerScript : MonoBehaviour // Script for the Instantiation of the arrow;
{
    [SerializeField] private GameObject Arrow;
    
    public void ArrowInstantiate()
    {
        var arrow = Instantiate(Arrow, transform.position, transform.rotation);
    }
}

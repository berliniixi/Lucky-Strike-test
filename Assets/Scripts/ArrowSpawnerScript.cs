using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawnerScript : MonoBehaviour // Script for the Instantiation of the arrow;
{
    [SerializeField] private GameObject Arrow;
    public bool arrowIsInstantiate = false;
    public void ArrowInstantiate()
    {
        if (arrowIsInstantiate)
        {
            return;
        }
        var arrow = Instantiate(Arrow, transform.position, transform.rotation);
    }
}

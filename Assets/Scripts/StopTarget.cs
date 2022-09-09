using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class StopTarget : MonoBehaviour
{
    [Header("Characteristics")]
    
    
    [Header("Components")]
    private TargetScript _targetScript;

    private ArrowFollowTarget _arrowFollowTarget;
    
    [SerializeField] private Transform target;
    
    void Start()
    {
        _targetScript = FindObjectOfType<TargetScript>();
    }

    public void PressToStopTarget()
    {
        _targetScript.isPressed = true;
    }

}

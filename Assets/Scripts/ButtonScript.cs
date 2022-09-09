using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ButtonScript : MonoBehaviour
{
    [Header("Characteristics")]
    
    
    [Header("Components")]
    private TargetScript _targetScript;
    [SerializeField] private Transform target;

    
    [Header("Reference to other Scripts")]
    private ArrowFollowTarget _arrowFollowTarget;
    
    
    void Start()
    {
        _targetScript = FindObjectOfType<TargetScript>();
        _arrowFollowTarget = FindObjectOfType<ArrowFollowTarget>();
    }
    
    public void PressToStopTarget() // Button.OnClick => Method that when the player press the button it will stop the target and the arrow will go to the target position;
    {
        _targetScript.isPressed = true; // Stop the target from movement
    }

    public void PressToShootTarget() // Button.OnClick => The arrow must go to the position of the target;
    {
        _arrowFollowTarget.allowArrowHit = true;
        _arrowFollowTarget.FixedUpdate();// Start the arrow going to the target;    
    }
}

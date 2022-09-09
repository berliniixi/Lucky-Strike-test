using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    [Header("Target Characteristics")] 
    [SerializeField] private float targetSpeed = 2f;
    [SerializeField] public bool isPressed;
    
    
    [Header("Target Components")]
    private Rigidbody2D _targetRigidbody2D;
    private BoxCollider2D _targetBoxCollider2D;
    private ArrowFollowTarget _arrowFollowTarget;
    
    void Awake()
    {
        _targetRigidbody2D = GetComponent<Rigidbody2D>();
        _targetBoxCollider2D = GetComponent<BoxCollider2D>();
        _arrowFollowTarget = GetComponent<ArrowFollowTarget>();
    }

    void FixedUpdate()
    {
        TargetMovement();
    }

    public void TargetMovement()       // Move the target on x-axis;
    {
        if (isPressed)
        {
            Debug.Log("return");
            _targetRigidbody2D.velocity = Vector2.zero;
            return;
            
        }
        _targetRigidbody2D.velocity = new Vector2(targetSpeed, 0f);
    }
    
    void OnTriggerEnter2D(Collider2D other) // if the target collide with the boxes makes the speed negative to move to the other direction
    {
        if (other.tag == "Colliders")
        {
            targetSpeed = -targetSpeed;
        }
    }
}
